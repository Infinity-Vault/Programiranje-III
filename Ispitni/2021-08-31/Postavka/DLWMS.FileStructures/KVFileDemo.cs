using DLWMS.FileStructures.Core;
using System.Collections.Generic;
using System.IO;

namespace DLWMS.FileStructures
{
    public class KVFileDemo
    {
        public static void SaveStudent(Student student)
        {
            StreamWriter sw = new StreamWriter("TestStudentSave.txt", true);
            sw.WriteLine($"Index = { student.Index}");
            sw.WriteLine($"Name = { student.Name}");
            sw.Close();
        }

        public static void SaveStudentDynamically(Student student)
        {
            var sw = new StreamWriter("REFLECTED.txt");
            var stdClassProps = student.GetType().GetProperties();

            for (int i = 0; i < stdClassProps.Length; i++)
            {
                sw.WriteLine($"{stdClassProps[i].Name} = {stdClassProps[i].GetValue(student)}");
            }

            sw.Close();
        }

        public static List<Student> LoadStudent(string fileName)
        {
            var lstStd = new List<Student>();
            StreamReader sr = new StreamReader(fileName);

            while (sr.Peek() != -1)
            {
                var line1 = sr.ReadLine();
                var line2 = sr.ReadLine();

                var strArr1 = line1.Split('=');
                var strArr2 = line2.Split('=');

                lstStd.Add(new Student() { Index = int.Parse(strArr1[1]), Name = strArr2[1] });
            }

            return lstStd;
        }
    }
}
