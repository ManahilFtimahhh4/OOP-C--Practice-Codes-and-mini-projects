using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {

        static void Main(string[] args) {



            //List<Product> productlist = new List<Product>();
            Product p = new Product();
            while (true) {
                Console.Clear();
               
                 p.Menu();
                Console.WriteLine("Enter the option you want to select : ");
                int op = int.Parse(Console.ReadLine());


                if (op == 1)
                {

                    p.AddProduct();

                }
                else if (op == 2)
                {
                    p.VeiwAllProducts();
                }

                else if (op == 3) {

                    p.HighestPrice();


                }
                else if (op == 4) {

                    p.tax();
                }
                else if (op == 5) {

                    p.threshold();

                }
                else {
                    Console.WriteLine("enter valid input");


                }
                Console.WriteLine("\nPress any key to continue...");
                Console.ReadKey();

            }

        }

    }


    class Product
    {
        public string Name;
        public string Catg;
        public int Price;
        public int StockQuantity;
        public int MinStockQuantity;
       public List<Product> productlist = new List<Product>();

        public Product() {

            //defualt constructor 

            MinStockQuantity = 10;
        }

        public Product(string name, string catg, int price, int stockQuantity, int minStockQuantity)
        {
            Name = name;
            Catg = catg;
            Price = price;
            StockQuantity = stockQuantity;
            MinStockQuantity = minStockQuantity;
        }
        public void Menu()
        {

            Console.WriteLine("----INVENTORY SYSTEM-----");

            Console.WriteLine("1.add new prodcut : ");
            Console.WriteLine("2.Veiw all product : ");
            Console.WriteLine("3.Find Product with the Highest Unit Price");
            Console.WriteLine("4.View Sales Tax of All Products.");
            Console.WriteLine("5.Products to be Ordered. (less than the threshold)");



        }
        public void AddProduct()
        {
            Product newProduct = new Product();
            Console.WriteLine("Enter the name of product : ");
            Name = Console.ReadLine();
            Console.WriteLine("Enter the category of product FRUITS/GROCERY : ");
            Catg = Console.ReadLine();
            Console.WriteLine("Enter the price of product");
            Price = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the stock quantity : ");
            StockQuantity = int.Parse(Console.ReadLine());
            newProduct.MinStockQuantity = MinStockQuantity; 

            productlist.Add(newProduct); 

        }
        public void VeiwAllProducts()
        {
            for (int i = 0; i < productlist.Count; i++) {
                Console.WriteLine(productlist[i]);
            }


        }
       
           public void HighestPrice()
        {
            Product highest = productlist[0]; 
            foreach (var product in productlist)
            {
                if (product.Price > highest.Price)
                {
                    highest = product;
                }
            }

            Console.WriteLine("Highest Price = " + highest);
        }




        
        public void tax()
        {
            int tax;
            if (Catg == "grocery")
            {
                tax = (Price / 100) * 10;
                Console.WriteLine($"tax is {tax}");
            }
            else if (Catg == "fruits")
            {
                tax = (Price / 100) * 15;
                Console.WriteLine($"tax is {tax}");
            }
            else
            {
                Console.WriteLine("enter valid input");
            }

        }
        public void threshold()
        {
            if(MinStockQuantity<StockQuantity )
            {
                Console.WriteLine("you need to place more order");
            } 
            else
            {
                Console.WriteLine("enough");
            }
            }
        }
    } 




