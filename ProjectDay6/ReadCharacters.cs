using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ProjectDay6
{
    class ReadCharacters
    {
        static void Main()
        {

           
            FileStream fs = new FileStream(@"D:\Data\f1.txt",FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(fs);
            while(reader.Peek()>-1)
            {
                Console.Write((char)reader.Read());
            }
            reader.Close();
            fs.Close();


        }
    }
}
