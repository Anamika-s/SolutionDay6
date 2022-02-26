using System;

namespace ProjectDay6
{
    class Program
    {
        static void Main(string[] args)
        {
            byte num, den;
            int res=0;
            int[] num1 = new int[10];
            try
            {
                Console.WriteLine("Enter Numerator");
                num = byte.Parse(Console.ReadLine());
                Console.WriteLine("Enter Denominator");
                den = byte.Parse(Console.ReadLine());
                res = num / den;
                num1[11] = 100;
            }
            catch(FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
           
            catch (OverflowException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception obj)
            {
                Console.WriteLine(obj.Message);
            }
            finally
            {
                Console.WriteLine("Res is " + res);
            }
        }
    }
}
