using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleCurso.SisEmployee.Entities
{
    //funcionario terceirizado
    class OutsourcedEmployee: Employee
    {
        //despesa adicional 
        public double AddtionalCharge { get; set; }

        public OutsourcedEmployee()
        {

        }

        public OutsourcedEmployee(string name, int hours, double valuePerHour, double addtionalcharge)
            :base(name, hours, valuePerHour)
        {
            AddtionalCharge = addtionalcharge;
        }

        public sealed override double Payment()
        {
            return base.Payment() + (AddtionalCharge * 1.10);
        }
    }
}
