using System;
using ConsoleCurso.ExceptionReservation.Entities;
using ConsoleCurso.ExceptionReservation.Entities.Exceptions;

namespace ConsoleCurso.ExceptionReservation
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                Console.Write("Room Number: ");
                int numero = int.Parse(Console.ReadLine());
                Console.Write("Check-in date (dd/MM/yyyy): ");
                DateTime e = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out date (dd/MM/yyyy): ");
                DateTime s = DateTime.Parse(Console.ReadLine());

                Reservation reserva = new Reservation(numero, e, s);
                Console.WriteLine(reserva);

                Console.WriteLine();
                Console.WriteLine("Enter data to update the reservation: ");

                Console.Write("Check-in date (dd/MM/yyyy): ");
                e = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out date (dd/MM/yyyy): ");
                s = DateTime.Parse(Console.ReadLine());

                reserva.UpdateDates(e, s);
                Console.WriteLine(reserva);
            }
            catch (DomainException e)
            {

                Console.WriteLine("Error in reservation: " + e.Message);
            }
            catch(FormatException e)
            {
                Console.WriteLine("Format error: " + e.Message);
            }
            catch(Exception e)
            {
                Console.WriteLine("Unexpected error: " + e.Message);
            }

        }


    }
}

