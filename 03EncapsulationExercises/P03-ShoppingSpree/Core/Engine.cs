using P03_ShoppingSpree.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P03_ShoppingSpree.Core
{
    public class Engine
    {
        private List<Person> people;
        private List<Product> products;

        public Engine()
        {
            this.people = new List<Person>();
            this.products = new List<Product>();
        }

        public void Run()
        {
            try
            {
                ReadPeopleInput();
                ReadProductsInput();

                
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }

            string command = Console.ReadLine();

            while (command != "END")
            {
                try
                {
                    string[] commandTokens = command.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

                    string personName = commandTokens[0];
                    string productName = commandTokens[1];

                    Person person = this.people.FirstOrDefault(p => p.Name == personName);
                    Product product = this.products.FirstOrDefault(p => p.Name == productName);

                    if (person != null && product != null)
                    {
                        person.BuyProduct(product);

                        Console.WriteLine($"{person.Name} bought {product.Name}");
                    }
                }
                catch (InvalidOperationException ex)
                {
                    Console.WriteLine(ex.Message);
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(Environment.NewLine, this.people));
        }

        private void ReadProductsInput()
        {
            string[] productsInput = Console.ReadLine().Split(";", StringSplitOptions.RemoveEmptyEntries).ToArray();

            foreach (var pt in productsInput)
            {
                string[] productsInfo = pt.Split("=").ToArray();

                string name = productsInfo[0];
                decimal cost = decimal.Parse(productsInfo[1]);

                Product product = new Product(name, cost);

                this.products.Add(product);
            }
        }

        private void ReadPeopleInput()
        {
            string[] personTokens = Console.ReadLine().Split(";", StringSplitOptions.RemoveEmptyEntries).ToArray();

            foreach (var pt in personTokens)
            {
                string[] personInfo = pt.Split("=").ToArray();

                string name = personInfo[0];
                decimal money = decimal.Parse(personInfo[1]);

                Person person = new Person(name, money);

                this.people.Add(person);
            }
        }
    }
}
