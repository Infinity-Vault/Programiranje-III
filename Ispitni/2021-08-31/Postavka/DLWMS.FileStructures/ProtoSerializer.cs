using System;
using DLWMS.FileStructures.Core;
using Google.Protobuf;
using ProtoDemo;

namespace DLWMS.FileStructures
{
    public class ProtoSerializer
    {
        public static void Ops()
        {
            var std = new Student() { Index = 1000, Name = "Some name" };

            StudentDataTransfer stdTransfer = new StudentDataTransfer()
            {
                Index = std.Index,
                Name = std.Name
            };


            var btArr = stdTransfer.ToByteArray();

            var deserialized = StudentDataTransfer.Parser.ParseFrom(btArr);
            Console.WriteLine(deserialized.Index + " " + deserialized.Name);
        }
    }
}
