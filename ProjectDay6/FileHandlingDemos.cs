using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ProjectDay6
{
    class FileHandlingDemos
    {
        static void Main()
        {

            FileInfo f1 = new FileInfo(@"D:\Data\f1.txt");
            FileStream fs = f1.Open(FileMode.Append, FileAccess.Write);
            StreamWriter writer = new StreamWriter(fs);
            writer.WriteLine("This is first line");
            writer.WriteLine("This is second line");
            writer.Close();
            fs.Close();

            fs = f1.Open(FileMode.Open, FileAccess.Read);
            StreamReader reader =  new StreamReader(fs);
            //string str = reader.ReadToEnd();
            //fs.Close();
            //reader.Close();
            //Console.WriteLine(str);
            string str = reader.ReadLine();
            while (str != null)
            {
                Console.WriteLine(str);
                str = reader.ReadLine();
            }




        }
    }
}
