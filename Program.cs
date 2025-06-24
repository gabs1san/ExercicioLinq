using System;
using System.Collections.Generic;
using ExercicioLinq.Entities;
using System.IO;
using System.Globalization;

namespace ExercicioLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter full file path");
            string path = Console.ReadLine();

            List<Product> list = new List<Product>();

            using (StreamReader sr = File.OpenText(path))
            {
                while (!sr.EndOfStream)
                {
                    string[] fields = sr.ReadLine().Split(',');
                    string name = fields[0];
                    double price = double.Parse(fields[1], CultureInfo.InvariantCulture);
                    list.Add(new Product(name, price));
                }
            }
        }
    }
}