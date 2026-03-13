using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace program1.cs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter number 1 : ");
            int Num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("entrer number 2 : ");
            int Num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter operator : ");
            char op = char.Parse(Console.ReadLine());



            Calculator s1 = new Calculator(Num1, Num2);

            if (op == '+') { Console.WriteLine("sum = " + s1.Add(Num1, Num2)); }

            if (op == '/') { Console.WriteLine("div = " + s1.Div(Num1, Num2)); }
            if (op == '*') {Console.WriteLine("mul = " + s1.Mul(Num1, Num2)); }
            if (op == '-') {Console.WriteLine("sub = " + s1.Sub(Num1, Num2));}





        }
        class Calculator
        {
            public Calculator(int p, int q)
            {

            }
            public int Add(int p, int q)
            {
                return p + q;

            }

            public int Mul(int p, int q)
            {
                return p * q;

            }
            public int Sub(int p, int q)
            {
                return p - q;

            }

            public int Div(int p, int q)
            {
                return p / q;

            }


        }



    }
}
