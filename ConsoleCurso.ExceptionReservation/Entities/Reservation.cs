using System;
using ConsoleCurso.ExceptionReservation.Entities.Exceptions;

namespace ConsoleCurso.ExceptionReservation.Entities
{
    class Reservation
    {
        public int RoomNumber { get; set; }

        public DateTime CheckIn { get; set; }
        
        public DateTime CheckOut { get; set; }

        public Reservation()
        {

        }

        public Reservation(int roomNumber, DateTime checkIn, DateTime checkOut)
        {
            if (checkOut <= checkIn)
            {
                throw new DomainException("Check-out date must be after check-in date");
            }

            RoomNumber = roomNumber;
            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        public int Duration()
        {
            //vamos pegamos a diferença entre um instante e outro.
            TimeSpan duration = CheckOut.Subtract(CheckIn);
            return (int)duration.TotalDays; // pegamos essa diferença em dias
        }

        public void UpdateDates(DateTime checkin, DateTime checkout)
        {
            DateTime now = DateTime.Now;
            if (checkin <= now || checkout <= now)
            {
                throw new DomainException ( "Informe datas futuras para atualizar reserva!");
            }
            if (checkout <= checkin)
            {
                throw new DomainException("Check-out date must be after check-in date");
            }

            CheckIn = checkin;
            CheckOut = checkout;
        }

        public override string ToString()
        {
            return "Room "
                + RoomNumber
                + ", check-in: "
                + CheckIn.ToString("dd/MM/yyyyy")
                + ", check-out: "
                + CheckOut.ToString("dd/MM/yyyy")
                + ", "
                + Duration()
                + "  nights";
        }
    }
}
