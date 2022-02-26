using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectDay6
{
    class StringFunctions
    {
        static void Main()
        {
            
            string sentence = "   This is session of C#"   ;
            string[] sent = sentence.Trim().Split(" ");
            foreach(string str in sent)
                Console.WriteLine(str);

            Console.WriteLine(sentence.Length);
            Console.WriteLine(sentence.ToUpper());
            Console.WriteLine(sentence.ToLower());
            Console.WriteLine(sentence.Trim());
            Console.WriteLine(sentence.Trim().Length);
            Console.WriteLine(sentence.IndexOf("C"));
            Console.WriteLine(sentence.Contains("p"));
            Console.WriteLine(sentence.Substring(2, 5));
            Console.WriteLine(string.Concat("a", "b"));

        }
    }
}
