using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace practice11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age;
            float machine;
            int toy;
            int price;
            int totalprice;

            Console.WriteLine("Enter Lilly's age:");
            age = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter price of washing machine:");
            machine = float.Parse(Console.ReadLine());

            Console.WriteLine("Enter price of Toys:");
            price = int.Parse(Console.ReadLine());

            Console.WriteLine("Number of Toys:");
            toy = int.Parse(Console.ReadLine());


            int amount = 10;
            int money = 0;
            for (int i = 2; i <= age; i += 2)
            {
                money += (amount - 1);
                amount += 10;
            }
            Console.WriteLine("The money she got on her even birthdays is: " + money);

            totalprice = price * toy;
            Console.WriteLine("Total price of toys: " + totalprice);

            int total = 0;
            for (int i = 1; i <= age; i += 2)
            {
                total += totalprice;
                Console.WriteLine("The total toys price she gets on odd birthdays is: " + total);


                int grand_total = money + total;
                Console.WriteLine("The grand total price is: " + grand_total);


                if (grand_total >= machine)
                {
                    Console.WriteLine("Yes! The money is sufficient to buy a washing machine!");
                }
                else
                {
                    Console.WriteLine("No! Money is not sufficient to buy a washing machine.");
                }

                Console.ReadKey();
            }
        }
    }
}
