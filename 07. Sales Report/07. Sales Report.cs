using System;
using System.Collections.Generic;
<<<<<<< HEAD
namespace _07.Sales_Report
{
    class Program
    {
=======

namespace _07.Sales_Report
{
    class Sale
    {
        public string Town { get; set; }
        public string Product { get; set; }
        public decimal Price { get; set; }
        public decimal Quantity { get; set; }
    }
}
    class Program
    {
>>>>>>> 2606df79081aa90e5cbe49d39a62c4697dd74a55
        static void Main(string[] args)
        {
            int countOfSales = int.Parse(Console.ReadLine());
            Sale[] sales = new Sale[countOfSales];
<<<<<<< HEAD
=======

>>>>>>> 2606df79081aa90e5cbe49d39a62c4697dd74a55
            for (int i = 0; i < countOfSales; i++)
            {
                sales[i] = ReadSale(Console.ReadLine());
            }
<<<<<<< HEAD
            SortedDictionary<string, decimal> dictionary = new SortedDictionary<string, decimal>();
=======

            SortedDictionary<string, decimal> dictionary = new SortedDictionary<string, decimal>();

>>>>>>> 2606df79081aa90e5cbe49d39a62c4697dd74a55
            foreach (Sale sale in sales)
            {
                if (dictionary.ContainsKey(sale.Town))
                {
                    dictionary[sale.Town] += sale.Price * sale.Quantity;
                }
                else
                {
                    dictionary[sale.Town] = sale.Price * sale.Quantity;
                }
            }
<<<<<<< HEAD
=======

>>>>>>> 2606df79081aa90e5cbe49d39a62c4697dd74a55
            foreach (var pair in dictionary)
            {
                Console.WriteLine("{0} -> {1:F2}", pair.Key, pair.Value);
            }
<<<<<<< HEAD
=======
        }

        static Sale ReadSale(string input)
        {
            string[] tokens = input.Split(' ');
            return new Sale { Town = tokens[0], Product = tokens[1], Price = decimal.Parse(tokens[2]), Quantity = decimal.Parse(tokens[3]) };
>>>>>>> 2606df79081aa90e5cbe49d39a62c4697dd74a55
        }
        static Sale ReadSale(string input)
        {
            string[] tokens = input.Split(' ');
            return new Sale { Town = tokens[0], Product = tokens[1], Price = decimal.Parse(tokens[2]), Quantity = decimal.Parse(tokens[3]) };
        }
    }
    class Sale
    {
        public string Town { get; set; }
        public string Product { get; set; }
        public decimal Price { get; set; }
        public decimal Quantity { get; set; }
    }
<<<<<<< HEAD
}
=======
>>>>>>> 2606df79081aa90e5cbe49d39a62c4697dd74a55
