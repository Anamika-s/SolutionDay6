using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ProjectDay6
{
    class StreamReaderDemo
    {
        static void Main()
        {
            StreamReader reader = null;
            try
            {
                string fileName = @"D:\Data\f1.txt";
                reader = new StreamReader(fileName);
                string str = reader.ReadLine();
                while (str != null)
                {
                    Console.WriteLine(str);
                    str = reader.ReadLine();
                }
            }
            catch(Exception obj)
            {
                Console.WriteLine(obj.Message);
            }
            finally
            { if(reader!=null)
                reader.Close();

            }
        }
    }
}
