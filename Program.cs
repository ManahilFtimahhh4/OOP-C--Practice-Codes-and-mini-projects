using program1.cs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.Remoting.Messaging;
using System.Runtime.Remoting.Services;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace program1.cs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            student s1 = new  student(1, "manahil","computer science ",2,34,67,77,35,67);

            Console.WriteLine(s1.avg());

            Console.WriteLine(s1.Grade());
            Console.WriteLine(s1.tmarks());
            Console.WriteLine(s1.Toostring());





        }

    }
    class student
    {

        public int id;
        public string name;
        public string departement;
        public int semester;
        public int marksOfSub1;
        public int marksOfSub2;
        public int marksOfSub3;
        public int marksOfSub4;
        public int marksOfSub5;
        public string grade;
        
        public int tmarks()
        {
            int tmarks = marksOfSub1 + marksOfSub2 + marksOfSub3 + marksOfSub4 + marksOfSub5;
            return tmarks;

        }
        public int avg()
        {
            

            int avg = tmarks() / 5;
            return avg;
        }
       public student(int id , string name , string departement , int semester , int marksOfSub1 , int marksOfsub2, int marksOfSub3, int marksOfSub4, int marksOfSub5)
        {
            this.name = name;
            this.id = id;
            this.departement = departement;
            this.semester= semester;
            this.marksOfSub1 = marksOfSub1;
            this.marksOfSub2 = marksOfsub2;
            this.marksOfSub3= marksOfSub3;
            this.marksOfSub4 = marksOfSub4;
            this.marksOfSub5 = marksOfSub5;

        }


        public string Grade()

        {
            double Avg = avg();

            if (avg() > 90)
            {
                return "A";
            }
            else if (avg() > 95)
            {
                return "B";
            }
            else if (avg() > 80 && avg() < 90)
            {
                return "C";
            }
            else if (avg() > 70 && avg() < 80)
            {
                return "D";
            }
            else
            {
                return "F";
            }

        }
        public string Toostring()
        {
            return "Name: " + name +
          ", Department: " + departement +
          ", Semester: " + semester +
          ", Marks: " + marksOfSub1 + ", " + marksOfSub2 + ", " +
                       marksOfSub3 + ", " + marksOfSub4 + ", " + marksOfSub5;
        }

    
           
        }
    }






