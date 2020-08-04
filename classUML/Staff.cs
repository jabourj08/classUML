using System;
using System.Collections.Generic;
using System.Text;

namespace classUML
{
    class Staff : Person
    {
        //Properties
        public string School { get; set; }
        public double Pay { get; set; }

        //Constructors
        public Staff()
        {

        }

        public Staff(int Type, string Name, string Address, string School, double Pay) :base(Type, Name, Address)
        {
            this.School = School;
            this.Pay = Pay;
        }

        //ToString Override
        public override string ToString()
        {
            return $"{base.ToString()}\n\tSchool: {School}\n\tPay: ${Pay}";
        }
    }
}
