using System;
using System.IO;
using System.Linq;

namespace practice11
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            int N = 3;    
            int Y = 200;  

           
            string filePath = "Customers.txt";

            
            string[] lines = File.ReadAllLines(filePath);

           
            foreach (string line in lines)
            {
                
                string[] parts = line.Split(' ');

                string name = parts[0]; 
                int numOrders = int.Parse(parts[1]); 
                string ordersString = parts[2]; 

                
                ordersString = ordersString.Trim('[', ']');
                int[] ordersArray = ordersString.Split(',').Select(int.Parse).ToArray();

                
                if (numOrders >= N && ordersArray.All(price => price >= Y))
                {
                    Console.WriteLine($"FREE pizza for {name}");
                }
            }

            Console.WriteLine("\nProgram finished!");
        }
    }
}
