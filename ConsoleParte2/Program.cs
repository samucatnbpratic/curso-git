using ConsoleParte2.Entities.Enums;
using System;
using ConsoleParte2.Entities;
using System.Globalization;

namespace ConsoleParte2
{
    class Program
    {
        static void Main(string[] args)
        {
            Client c = new Client();
            Order order = new Order();
            Product prod = new Product();
            OrderItem orderitem = new OrderItem();

            Console.WriteLine("Enter cliente data: ");
            Console.Write("Name: ");
            c.Name = Console.ReadLine();
            Console.Write("Email: ");
            c.Email = Console.ReadLine();
            Console.Write("Birth date: ");
            c.BirthDate = DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy", CultureInfo.InvariantCulture);

            order.Cliente = c;

            Console.WriteLine("Enter cliente data: ");
            Console.Write("Status: ");
            order.Moment = DateTime.Now;
            order.Status = Enum.Parse<OrderStatus>(Console.ReadLine());
            Console.Write("How many items to this order: ");
            int qtd = int.Parse(Console.ReadLine());
            for (int i = 0; i < qtd; i++)
            {
                Console.WriteLine($"Enter #{i} item data: ");
                Console.Write("Product Name: ");
                prod.Name = Console.ReadLine();
                Console.Write("Product Price: ");
                prod.Price = double.Parse(Console.ReadLine());
                Console.Write("Product Quantity: ");
                orderitem.Quantity = int.Parse(Console.ReadLine());
                orderitem.Produto = prod;
                order.Itens.Add(orderitem);

            }


            Console.WriteLine(order);

            /*
            Order order = new Order
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };
            Console.WriteLine(order);

            string txt = OrderStatus.PendingPayment.ToString();
            Console.WriteLine(txt);

            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");
            Console.WriteLine(os);
            */
        }
    }
}
