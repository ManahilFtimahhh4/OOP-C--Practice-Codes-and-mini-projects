using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asses1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Bank b;
            b = new HBL();
            Console.WriteLine("Interest Rate: " + b.getInterestrate() + "%");


        }

       
      
            
        
    }

    abstract class Bank
    {
        public void CardIssued()
        {
            Console.WriteLine("Card issued to the customer");
        }
        public abstract int getInterestrate();
        
    }
    class HBL : Bank
    {
        public override int getInterestrate()
        {
           return 10;
        }
    }
}
