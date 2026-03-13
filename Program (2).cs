using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice11
{
    internal class Program
    {
        static void Main(string[] args)
        {

            float area;
            Console.WriteLine("enter the length : ");
            int length = int.Parse(Console.ReadLine());
            area = length * length;
            Console.WriteLine("Area is "+ area);


        }
    }
}
