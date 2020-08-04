using System;
using System.Collections.Generic;
using System.Text;

namespace classUML
{
    class Student : Person
    {
        //Properties
        public string Program { get; set; }
        public int Year { get; set; }
        public double Fee { get; set; }

        //Constructors
        public Student()
        {

        }

        public Student(int Type, string Name, string Address, string Program, int Year, double Fee) :base(Type, Name, Address)
        {
            this.Program = Program;
            this.Year = Year;
            this.Fee = Fee;
        }

        //ToString Override
        public override string ToString()
        {
            return $"{base.ToString()}\n\tProgram: {Program}\n\tYear: {Year}\n\tFee: ${Fee}";
        }
    }
}
