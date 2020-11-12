using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleCurso.SisEmployee.Entities
{
    //funcionarios
    class Employee
    {
        public string Name { get; set; }
        //quantidade horas trabalhadas
        public int Hours { get; set; }
        //valor por hora
        public double ValuePerHour { get; set; }

        public Employee()
        {

        }

        public Employee(string name, int hours, double valuePerHour)
        {
            Name = name;
            Hours = hours;
            ValuePerHour = valuePerHour;
        }

        public virtual double Payment()
        {
            return Hours * ValuePerHour;
        }
    }
}
