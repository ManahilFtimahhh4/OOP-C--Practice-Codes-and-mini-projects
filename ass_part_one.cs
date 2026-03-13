using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Animal> A = new List<Animal>();
            A.Add(new Cat());
            A.Add(new Dog());

            foreach(var a in A)
            {
                a.MakeSound();
            }



        }
    }

    class Animal
    {
        public void MakeSound()
        {

            Console.WriteLine("Some generic animal sound.");

        }
    }


    class Cat : Animal
    {
        public new void MakeSound()
        {

            Console.WriteLine("Mewon");

        }

    }

    class Dog : Animal {

        public new void MakeSound()
        {
            Console.WriteLine("wooff");
        }
    
    
    }
}