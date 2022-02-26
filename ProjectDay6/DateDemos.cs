using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectDay6
{
    class DateDemos
    {
        static void Main()
        {
            //DateTime dob = new DateTime(1974, 7, 10, 7, 10, 24);
            //Console.WriteLine("Day:{0}", dob.Day);
            //Console.WriteLine("Month:{0}", dob.Month);
            //Console.WriteLine("Year:{0}", dob.Year);
            //Console.WriteLine("Hour:{0}", dob.Hour);
            //Console.WriteLine("Minute:{0}", dob.Minute);
            //Console.WriteLine("Second:{0}", dob.Second);
            //Console.WriteLine("Millisecond:{0}", dob.Millisecond);

            //Console.WriteLine("Day of Week:{0}", dob.DayOfWeek);
            //Console.WriteLine("Day of Year: {0}", dob.DayOfYear);
            //Console.WriteLine("Time of Day:{0}", dob.TimeOfDay);
            //Console.WriteLine("Tick:{0}", dob.Ticks);
            //Console.WriteLine("Kind:{0}", dob.Kind);
            DateTime aDay = DateTime.Now;
            Console.WriteLine(aDay);
            Console.WriteLine(aDay.ToString("d"));
            Console.WriteLine(aDay.ToString("D"));
            Console.WriteLine(aDay.ToString("M"));
            Console.WriteLine(aDay.ToString("m"));
            Console.WriteLine(aDay.ToString("f"));
            Console.WriteLine(aDay.ToString("F"));
            Console.WriteLine(aDay.AddDays(2));





        }
    }
}
