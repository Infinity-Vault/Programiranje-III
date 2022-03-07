using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace DLWMS.FileStructures
{
    public enum SerializationType
    {
        Json,
        Binary
    }
    /// <summary>
    /// Index number, Name and Lastname added JSON
    /// </summary>
    public class Serializer
    {
        #region Save to a file

        public static void SerializeObject<T>(T ObjectGraph, string FileName, SerializationType SerializeType = SerializationType.Binary, bool ReWrite = false)
        {
            var fs = new FileStream(FileName, ReWrite ? FileMode.Create : FileMode.Append, FileAccess.Write, FileShare.None);

            IFormatter formatter;
            formatter = new BinaryFormatter();

            try
            {
                fs.Position = fs.Seek(0, SeekOrigin.End);
                formatter.Serialize(fs, ObjectGraph);
            }
            catch (SerializationException e)
            {
                Debug.WriteLine("Failed to serialize. Error: " + e.Message);
            }
            finally
            {
                fs.Close();
            }
        }

        public static void SerializeObject<T>(T ObjectGraph, out long Size, string FileName, SerializationType SerializeType = SerializationType.Binary, bool ReWrite = false)
        {
            var fs = new FileStream(FileName, ReWrite ? FileMode.Create : FileMode.Append, FileAccess.Write, FileShare.None);

            IFormatter formatter;
            formatter = new BinaryFormatter();

            try
            {
                fs.Position = fs.Seek(0, SeekOrigin.End);
                formatter.Serialize(fs, ObjectGraph);
                Size = fs.Length;
            }
            catch (SerializationException e)
            {
                Size = 0;
                Debug.WriteLine("Failed to serialize. Error: " + e.Message);
            }
            finally
            {
                fs.Close();
            }
        }
        #endregion

        #region Serialize and Deserialize Object To String
        public static string SerializeObjectToString<T>(T ObjectGraph)
        {
            IFormatter formatter = new BinaryFormatter();
            using (MemoryStream ms = new MemoryStream())
            {
                formatter.Serialize(ms, ObjectGraph);
                return Convert.ToBase64String(ms.ToArray());
            }
        }

        public static T DeserializeObjectFromString<T>(string ObjectGraph)
        {
            byte[] bytes = Convert.FromBase64String(ObjectGraph);
            using (var ms = new MemoryStream(bytes))
            {
                BinaryFormatter bformatter = new BinaryFormatter();
                var returnObject = (T)bformatter.Deserialize(ms);
                return returnObject;
            }
        }
        #endregion

        #region Load from a file
        public static List<T> DeserializeList<T>(string FileName, long Position = 0, SerializationType SerializeType = SerializationType.Binary)
        {
            var objList = new List<T>();
            var fs = new FileStream(FileName, FileMode.Open);

            IFormatter formatter;
            formatter = new BinaryFormatter();

            try
            {
                fs.Position = Position;
                while (fs.Length != fs.Position)
                {
                    var obj = (T)formatter.Deserialize(fs);
                    objList.Add(obj);
                }
                return objList;
            }
            catch (SerializationException e)
            {
                Console.WriteLine("Deserialization failed. Error: " + e.Message);
            }
            finally
            {
                fs.Close();
            }

            return null;
        }

        public static T DeserializeObject<T>(string FileName, SerializationType SerializeType = SerializationType.Binary)
        {
            var fs = new FileStream(FileName, FileMode.Open);

            IFormatter formatter;

            formatter = new BinaryFormatter();

            try
            {
                fs.Position = 0;
                return (T)formatter.Deserialize(fs);
            }
            catch (SerializationException e)
            {
                Console.WriteLine("Deserialization failed. Error: " + e.Message);
            }
            finally
            {
                fs.Close();
            }

            return default(T);
        }
        #endregion
    }
}
