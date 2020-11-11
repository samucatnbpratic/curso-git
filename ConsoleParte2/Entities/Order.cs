using ConsoleParte2.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ConsoleParte2.Entities
{
    class Order
    {
        public int Id { get; set; }
        public DateTime Moment { get; set; }

        public OrderStatus Status { get; set; }

        public List<OrderItem> Itens = new List<OrderItem>();

        public Client Cliente = new Client();

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("ORDER SUMMARY");
            sb.Append("Order moment: ");
            sb.AppendLine(Moment.ToString());
            sb.Append("Order status: ");
            sb.AppendLine(Status.ToString());
            sb.Append("Client: ");
            sb.Append(Cliente.Name);
            sb.Append("(" + Cliente.BirthDate.ToString("dd/MM/yyyy") + ") - ");
            sb.AppendLine(Cliente.Email);
            sb.AppendLine("Order items: ");
            foreach (OrderItem item in Itens)
            {
                sb.Append(item.Produto.Name);
                sb.Append(", $ ");
                sb.Append(item.Price.ToString("F2"));
                sb.Append("  Quantity: ");
                sb.Append(item.Quantity.ToString("F3"));
                sb.Append("  Subtotal: $ ");
                sb.AppendLine(item.SubTotal().ToString("F2"));

            }
            sb.Append("TOTAL PRICE: $");
            sb.AppendLine(Total().ToString("F2", CultureInfo.InvariantCulture));
            return sb.ToString();
        }


        public void AddItem(OrderItem item)
        {
            Itens.Add(item);
        }

        public void RemoveItem(OrderItem item)
        {
            Itens.Remove(item);
        }

        public double Total()
        {
            double total = 0.0;
            foreach (OrderItem item in Itens)
            {
                total += item.SubTotal();
            }
            return total;
        }
    }
}
