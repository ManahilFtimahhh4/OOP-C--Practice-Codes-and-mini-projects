using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ClockType default_time = new ClockType();

            ClockType hours = new ClockType(9);
            Console.WriteLine("only hours ");
            hours.PrintType();

            ClockType minutes = new ClockType(9,10);
            Console.WriteLine("only minutes");
            minutes.PrintType();

            ClockType seconds = new ClockType(9,10,20);
            Console.WriteLine("only seconds");
            seconds.PrintType();


            seconds.incrementedHours();
            Console.WriteLine("  ");
            seconds.PrintType();


            


            seconds.incrementedMinutes();
            Console.WriteLine("  ");
            seconds.PrintType();

            seconds.incrementedSeconds();
            Console.WriteLine("  ");
            seconds.PrintType();

            bool flag = seconds.isequal(10, 11, 21);

            Console.WriteLine("flag: " + flag);
            ClockType cmp = new ClockType(10,12,11);
            flag = seconds.isequal(cmp);
            Console.WriteLine("object flag: " + flag);
            

            seconds.comparewith(cmp);
            ClockType clock = new ClockType(9, 10, 20);
            
            clock.elapsedTime(clock.hours, clock.minutes, clock.seconds);
            clock.RemainingTime();



        }
    }
    class ClockType
    {
        public int hours;
        public int minutes;
       public int seconds;

        public ClockType()
        {
          hours= 0;
            minutes= 0;
            seconds= 0;

        }
       
        public ClockType(int h)
        {
            hours = h;

        }
        public ClockType(int h , int m )
        {
            hours = h;
            minutes = m;


        }
        public ClockType(int h, int m , int s)

        {
            hours = h;
            minutes = m;
            seconds = s;

        }

        public void  PrintType()
        {
            Console.WriteLine(hours + ": " + minutes + " :" + seconds);
        }
        public int incrementedHours()
        {
            return
            hours++;
            
        }
        public int incrementedMinutes() { 
            return
                minutes++;  
        
        
        }
        public int incrementedSeconds() { 
        
        
        
        return seconds++;
        }
        public bool isequal(int h, int m, int s)
        {
            if (hours == h && minutes == m && seconds == s)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool isequal(ClockType temp)
        {
            if(hours==temp.hours && minutes==temp.minutes && seconds==temp.seconds)
            {
                return true;
            }
            else
            {
               return false;
            }
        }
        public void comparewith(ClockType other)
        {
            int thisTotal=hours*3600 + minutes*60 + seconds;
            int otherTotal=other.hours*3600 + other.minutes*60 + other.seconds;

           int diff = thisTotal - otherTotal;

            int h = diff / 3600;
            int m = (Math.Abs(diff) % 3600) / 60;
            int s = Math.Abs(diff) % 60;
            Console.WriteLine($"diffrence {h:D2} : {m:D2} : {s:D2}");
        }
      
        public int elapsedTime(int h , int m , int s)
        {
           int  Esec=h*3600+m*60+s;

            Console.WriteLine($"Elapsed time is {Esec}");
            return Esec;
        }
        public int RemainingTime()

        {
           int  RemainingTime = 24 * 3600 - elapsedTime(hours, minutes, seconds);
            Console.WriteLine($"rremaining time is {RemainingTime}");
            return RemainingTime;




        }
    }
}
