using System;
using System.Collections.Generic;
using System.Text;

namespace classUML
{
    class Person
    {
        //Properties
        public int Type { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        //constructors
        public Person()
        {

        }

        public Person(int Type, string Name, string Address)
        {
            this.Type = Type;
            this.Name = Name;
            this.Address = Address;
        }

        //ToString Override
        public override string ToString()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine();
            if (Type == 1)
            {
                Console.WriteLine($"Regular Person");
            }
            else if (Type == 2)
            {
                Console.WriteLine($"Student");
            }
            else if (Type == 3)
            {
                Console.WriteLine($"Staff Member");
            }
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            return $"\tName: {Name}\n\tAddress: {Address}";
        }
    }
}
