using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectDay6
{
    class Customer
    {
        string name;
        int age;
        public void Get()
        {
            try
            {
                Console.WriteLine("Enter Name");
                name = Console.ReadLine();
                if (name.Length < 10)
                //    Console.WriteLine("Length is 10");
                throw new CustomException("Min 10 characters are needed");
                Console.WriteLine("Enter Age");
                age = Convert.ToByte(Console.ReadLine());
                if (age < 20 || age > 50)
                    throw new CustomException("Range for Age is 20 to 40");
                }
            catch(CustomException ex)
            {
                Console.WriteLine(ex.Message);
            }
            
            }
        public void Show()
        {
            Console.WriteLine("Name is" +name);
            Console.WriteLine("Age is  " + age);
        }
    }
}
