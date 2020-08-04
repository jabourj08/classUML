using System;
using System.Collections.Generic;

namespace classUML
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>
            {
                new Person(1,"Josh","1325 Montgomery Lane"),
                new Person(1,"Shane","6451 Monopoly Way"),
                new Person(1,"Brad","6511 Redford Street"),
                new Person(1,"Tom","1564 Hickory Drive"),
                new Person(1,"Jason","1652 Mackerly Boulevard"),
                new Student(2,"Snap","6458 Kelloggs Lane", "Java", 1988, 465.14),
                new Student(2,"Crackle","6458 Kelloggs Lane", "C#", 1989, 156.64),
                new Student(2,"Pop","6458 Kelloggs Lane", "Front End", 1990, 6514.64),
                new Staff(3,"Pinky","1995 Acme Labs Road","Acme Academy",100000),
                new Staff(3,"The Brain","1995 Acme Labs Road","Acme Academy",500000),
            };

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("***** Hello and welcome to the people program thing! *****");
            Console.WriteLine();
            MainMenu(people);
        }

        //Main Menu
        public static void MainMenu(List<Person> people)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine($"You currently have {people.Count} people in the list...");
            Console.WriteLine("What would you like to do?");
            Console.WriteLine();
            Console.WriteLine("1) List People");
            Console.WriteLine("2) Add Person");
            Console.WriteLine("3) Exit");
            Console.WriteLine();
            Console.Write("Enter 1-3: ");
            Console.ResetColor();
            int userSelection = CheckNumber(Console.ReadLine(), true, 3);

            if (userSelection == 1)
            {
                ListPeople(people);
            }
            else if (userSelection == 2)
            {
                AddPerson(people);
            }
            else if (userSelection == 3)
            {
                ExitProgram(people);
            }
        }
        //Print Lists
        public static void ListPeople(List<Person> people)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("How would you like to list your peeps?");
            Console.WriteLine();
            Console.WriteLine("1) All People");
            Console.WriteLine("2) Regular Person");
            Console.WriteLine("3) Student");
            Console.WriteLine("4) Staff Member");
            Console.WriteLine();
            Console.Write("Enter 1-4: ");
            Console.ResetColor();
            int userSelection = CheckNumber(Console.ReadLine(), true, 4);

            foreach (Person person in people)
            {
                if (userSelection == 1)
                {
                    Console.WriteLine(person.ToString());
                    Console.WriteLine();
                }
                else if (userSelection == 2)
                {
                    if (person.Type == 1)
                    {
                        Console.WriteLine(person.ToString());
                        Console.WriteLine();
                    }
                }
                else if (userSelection == 3)
                {
                    if (person.Type == 2)
                    {
                        Console.WriteLine(person.ToString());
                        Console.WriteLine();
                    }
                }
                else if (userSelection == 4)
                {
                    if (person.Type == 3)
                    {
                        Console.WriteLine(person.ToString());
                        Console.WriteLine();
                    }
                }
            }
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("----------------------------------------------");
            ReturnToMain(people);
        }
        //Add person to list
        public static void AddPerson(List<Person> people)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Who are you entering information for?");
            Console.WriteLine();
            Console.WriteLine("1) Regular Person");
            Console.WriteLine("2) Student");
            Console.WriteLine("3) Staff Member");
            Console.WriteLine();
            Console.Write("Enter 1-3: ");
            Console.ResetColor();
            int userSelection = CheckNumber(Console.ReadLine(), true, 3);

            int type = 0;
            string name = "";
            string address = "";
            string program = "";
            string school = "";
            int year = 0;
            double pay = 0;
            double fee = 0;

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("Enter their name: ");
            Console.ResetColor();
            name = CheckString(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write($"Enter {name}'s address: ");
            Console.ResetColor();
            address = CheckString(Console.ReadLine());

            if (userSelection == 1)
            {
                type = 1;
                people.Add(new Person(type,name,address));
            }
            else if (userSelection == 2)
            {
                type = 2;
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write($"Enter {name}'s Program: ");
                Console.ResetColor();
                program = CheckString(Console.ReadLine());

                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write($"Enter {name}'s Year: ");
                Console.ResetColor();
                year = CheckNumberYear(Console.ReadLine());

                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write($"Enter {name}'s Tuition: ");
                Console.ResetColor();
                fee = CheckNumberDecimal(Console.ReadLine());

                people.Add(new Student(type,name,address,program,year,fee));
            }
            else if (userSelection == 3)
            {
                type = 3;
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write($"Enter {name}'s School: ");
                Console.ResetColor();
                school = CheckString(Console.ReadLine());

                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write($"Enter {name}'s Salary: ");
                Console.ResetColor();
                pay = CheckNumberDecimal(Console.ReadLine());

                people.Add(new Staff(type,name,address,school,pay));
            }

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Success! {name} has been added to the list!");
            ReturnToMain(people);
        }
        //Check for null entry
        public static string CheckString(string input)
        {
            string validString = "";
            bool invalid = true;
            while (invalid)
            {
                try
                {
                    validString = input;
                    invalid = false;
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Why u no listen??? Enter some text you silly goose!");
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    BeepBoops();
                    Console.Write("Please try again: ");
                    Console.ResetColor();
                    input = Console.ReadLine();
                }
            }
            return validString;
        }
        //Check for 4 digit number
        public static int CheckNumberYear(string input)
        {
            int validNumber = 0;
            bool invalid = true;
            while (invalid)
            {
                try
                {
                    validNumber = int.Parse(input);
                    if (input.Length == 4)
                    {
                        invalid = false;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Why u no listen??? I said gimme a \"4 DIGIT\" year (ex. 2020)");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        BeepBoops();
                        Console.Write("Please try again: ");
                        Console.ResetColor();
                        input = Console.ReadLine();
                    }
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Why u no listen??? That is not a 4 digit year.");
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    BeepBoops();
                    Console.Write("Please try again: ");
                    Console.ResetColor();
                    input = Console.ReadLine();
                }
            }
            return validNumber;
        }
        //Check for number
        public static int CheckNumber(string input, bool rangeCheck, int num)
        {
            int validNumber = 0;
            bool invalid = true;
            while (invalid)
            {
                try
                {
                    validNumber = int.Parse(input);

                    if (rangeCheck)
                    {
                        if (validNumber > 0 && validNumber <= num)
                        {
                            invalid = false;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Why u no listen??? I said enter a number from 1-" + num + ".");
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            BeepBoops();
                            Console.Write("Please try again: ");
                            Console.ResetColor();
                            input = Console.ReadLine();
                        }
                    }
                    else
                    {
                        invalid = false;
                    }
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Why u no listen??? Enter a number");
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    BeepBoops();
                    Console.Write("Please try again: ");
                    Console.ResetColor();
                    input = Console.ReadLine();
                }
            }
            return validNumber;
        }
        //Check for number
        public static double CheckNumberDecimal(string input)
        {
            double validNumber = 0;
            bool invalid = true;
            while (invalid)
            {
                try
                {
                    validNumber = Double.Parse(input);
                    invalid = false;
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Why u no listen??? Enter a number.");
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    BeepBoops();
                    Console.Write("Please try again: ");
                    Console.ResetColor();
                    input = Console.ReadLine();
                }
            }
            return validNumber;
        }
        //Check for y/n
        public static string CheckDecision(string input)
        {
            bool invalid = true;
            while (invalid)
            {
                if (input.ToLower() == "y")
                {
                    input = "y";
                    invalid = false;
                }
                else if (input.ToLower() == "n")
                {
                    input = "n";
                    invalid = false;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Why u no listen??? I said enter y/n");
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    BeepBoops();
                    Console.Write("Please try again: ");
                    Console.ResetColor();
                    input = Console.ReadLine();
                }
            }
            return input;
        }
        //Return to main menu
        public static void ReturnToMain(List<Person> people)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine();
            Console.Write("Press any key to return to the Main Menu...");
            Console.ResetColor();
            Console.ReadKey();
            Console.WriteLine();
            Console.Clear();
            MainMenu(people);
        }
        //Determine if user wants to Exit Program
        public static void ExitProgram(List<Person> people)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Are you sure you want to Quit? y/n");
            string input = CheckDecision(Console.ReadLine());

            if (input == "y")
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("***** Thank you for using the people program thing! Have a great day! *****");
                Console.Write(" Press any key to exit...");
                Console.ReadKey();
            }
            else
            {
                ReturnToMain(people);
            }            
        }
        //Addz Cool Zoundz!!! Because why not??
        public static void BeepBoops()
        {
            Console.Beep(1000, 100); Console.Beep(1000, 100); Console.Beep(1000, 100);
            Console.Beep(2000, 100); Console.Beep(2000, 100); Console.Beep(2000, 100);
        }
    }
}
