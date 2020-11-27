using ConsoleCurso.ExercicioAbstract.Entities;
using ConsoleCurso.ExercicioAbstract.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;

namespace ConsoleCurso.ExercicioAbstract
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("pt-BR");
            int teste = 1; //flag para mudar teste
            if (teste == 1)
                Shape();
            else
                Account();

        }

        private static void Account()
        {
            //utilizando um exemplo com a classe abstract
            List<Account> list = new List<Account>();

            list.Add(new BusinessAccount(1001, "João", 500, 100));
            list.Add(new SavingsAccount(1001, "Maria", 500, 0.10));
            list.Add(new BusinessAccount(1001, "Ricardo", 500, 500));
            list.Add(new SavingsAccount(1001, "Terebentina", 500, 0.10));

            foreach (Account item in list)
            {
                item.Withdraw(100.0);
                if (item is SavingsAccount)
                {
                    SavingsAccount s = (SavingsAccount)item;
                    s.UpdateBalance();
                }

            }

            foreach (Account item in list)
            {

                Console.WriteLine(item.Balance);
            }

        }

        private static void Shape()
        {
            try
            {

                List<IShape> figura = new List<IShape>();

                Console.Write("Enter the number of shapes: ");
                int n = int.Parse(Console.ReadLine());
                for (int i = 1; i <= n; i++)
                {
                    Console.WriteLine($"Shape {i} data ");
                    Console.Write("Rectangle or Circle (r/c)? ");
                    char f = char.Parse(Console.ReadLine());
                    Console.Write("Color (Black/Blue/Red): ");
                    Color c = Enum.Parse<Color>((Console.ReadLine()));
                    if (f == 'r')
                    {
                        Console.Write("Width: ");
                        double w = double.Parse(Console.ReadLine());
                        Console.Write("Height: ");
                        double h = double.Parse(Console.ReadLine());
                        figura.Add(new Rectangle(w, h, c));
                    }
                    else
                    {
                        Console.Write("Radius: ");
                        double r = double.Parse(Console.ReadLine());
                        figura.Add(new Circle(r, c));

                    }
                }
                Console.WriteLine("SHAPE AREAS: ");
                foreach (IShape item in figura)
                {
                    Console.WriteLine(item.Area());

                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message.ToString());
            }

        }
    }
}
