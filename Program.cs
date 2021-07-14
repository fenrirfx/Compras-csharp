using System;
using System.Collections.Generic;
using Compras.Entities;

namespace Compras
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> prod = new List<Product>();
            
            Console.Write("Insira a quantidade de produtos: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Product #{i} data");
                Console.Write("Common, used or imported (c/u/i)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Pice: ");
                double price = double.Parse(Console.ReadLine());
                if (ch == 'u')
                {
                    Console.Write("Manufactured date (DD/MM/YYYY): ");
                    DateTime date = DateTime.Parse(Console.ReadLine());
                    prod.Add(new UsedProduct(name, price, date));
                }
                else if (ch == 'i')
                {
                    Console.Write("Customs Fee: ");
                    double fee = double.Parse(Console.ReadLine());
                    prod.Add(new ImportedProduct(name, price, fee));
                }
                else
                {
                    prod.Add(new Product(name, price));
                }
            }
            Console.WriteLine();
                foreach(Product obj in prod)
                {

                    Console.WriteLine(obj.priceTag());
                }
            }
        }
    }

