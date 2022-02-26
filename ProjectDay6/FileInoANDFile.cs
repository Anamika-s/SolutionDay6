using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ProjectDay6
{
    class FileInoANDFile
    {
        static void Main()
        {
            FileInfo fi = new FileInfo(@"D:\Data\f3.txt");
            fi.Create();
            File.Create(@"D:\Data\file100.txt"); 
            File.Delete(@"D:\Data\f1.txt");

            DirectoryInfo di = new DirectoryInfo(@"D:\Data");
           // di.Create();

            DirectoryInfo[] df = di.GetDirectories();
            foreach(DirectoryInfo temp in  df)
                Console.WriteLine(temp.Name);
            FileInfo[] files = di.GetFiles();
            foreach (FileInfo temp in files)
                Console.WriteLine(temp.Name + " " + temp.CreationTime);

            Directory.CreateDirectory(@"D:\Dat100");
            string[] fs = Directory.GetFiles(@"D:\Data");



        }
    }
}
