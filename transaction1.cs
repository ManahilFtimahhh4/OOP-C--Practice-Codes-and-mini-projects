using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace program1.cs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Transaction s1 = new Transaction();

            Transaction s2 = new Transaction(s1);

            Transaction s3 = new Transaction();

            s3.ProductName = "tv";
            s3.Amount = 23497;
            s3.Date = "5oct2024";
            s3.time = "3:00";

            s1.Show();
            s2.Show();
            s3.Show();
        }



        class Transaction
        {
            public string ProductName;
            public float Amount;
            public string Date;
            public string time;

            public Transaction()
            {
                ProductName = "laptop";
                Amount = 30000f;
                Date = "4january2005";
                time = "4:00";
            }
            public Transaction(Transaction s)
            {
                this.ProductName = s.ProductName;
                this.Amount = s.Amount;
                this.Date = s.Date;
                this.time = s.time;
            }
            public void Show()
            {
                Console.WriteLine($"Product: {ProductName}, Amount: {Amount}, Date: {Date}, Time: {time}");
            }


        }
    }
}
