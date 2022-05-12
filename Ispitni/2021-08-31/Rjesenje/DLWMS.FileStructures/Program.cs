using DLWMS.FileStructures.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLWMS.FileStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            //KVFileDemo.SaveStudent(new Student() { Index = 1000, Name = "Some name" });

            //KVFileDemo.SaveStudentDynamically(new Student() { Index = 2000, Name = "Some crazy name" });

            //var lstStdLoaded = KVFileDemo.LoadStudent("TestStudentSave.txt");
            //foreach (var item in lstStdLoaded)
            //{
            //    Console.WriteLine(item);
            //}

            //DelimterFileDemo.SaveDelimitedFile();
            //DelimterFileDemo.SaveCSV();
            //var std = new Student() { Index = 1000, Name = "SomeName" };

            //Serializer.SerializeObject<Student>(std, "StudentBinary.txt", SerializationType.Binary);

            //Console.WriteLine(Serializer.DeserializeObject<Student>("StudentBinary.txt"));

            ProtoSerializer.Ops();
        }
    }
}
