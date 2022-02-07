using System.IO;

namespace DLWMS.FileStructures
{
    public class DelimterFileDemo
    {
        public static void SaveDelimitedFile()
        {
            var sw = File.AppendText("Delimited.csv");

            for (int i = 0; i < 500; i++)
                sw.Write(i + ",");

            sw.Close();
        }

        public static void SaveCSV() // Shows how to arrange data in columns to be interpretted by Excel
        {
            using (StreamWriter sw = File.AppendText("DelimitedWithColumns.csv"))
            {
                for (int i = 0; i < 4000; i++)
                {
                    sw.WriteLine(i + "," + (i * 100) + "," + (i - 10));
                }

                sw.Close();
            }
        }
    }
}
