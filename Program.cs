using System;
using System.Collections.Generic;

namespace PracticeCSharp
{
    
    class CalculatorBrain
    {
        public double Addition(double num1,double num2)
        {
            return (num1 + num2);
        }

        public double Subtraction(double num1, double num2)
        {
            return (num1 - num2);
        }

        public double Multiply(double num1, double num2)
        {
            return (num1 * num2);
        }

        public double Division(double num1, double num2)
        {
            return (num1/num2);
        }
        public void DisplayResult(double num1)
        {
            Console.Write("Result = ");
            Console.WriteLine(num1);
        }

    }
    class PhoneBook
    {
        public string name { get; set; }
        public string phone { get; set; }
        public string state { get; set; }
        public string city { get; set; }

        ~PhoneBook() { }
    }


    class Program
    {
        static void Calculator()
        {
            CalculatorBrain calci = new CalculatorBrain();

            Console.WriteLine("--------------Menual------------------ \nStep 1.Enter First Number. \nStep 2.Enter Operator.\nStep 3.Enter Second Number\n  Table of Operators \n\t+ = Additiion\n\t- = Subtraction\n\t* =  Multiply\n\t/ = Division\n  Press Q to Quit");
            double num1 = Convert.ToDouble(Console.ReadLine());
            string Operator = Console.ReadLine();
            while (Operator != "Q")
            {
                double num2 = Convert.ToDouble(Console.ReadLine());
                switch (Operator)
                {
                    case "+":
                        num1 = calci.Addition(num1, num2);
                        calci.DisplayResult(num1);
                        break;

                    case "-":
                        num1 = calci.Subtraction(num1, num2);
                        calci.DisplayResult(num1);
                        break;

                    case "/":
                        num1 = calci.Division(num1, num2);
                        calci.DisplayResult(num1);
                        break;

                    case "*":
                        num1 = calci.Multiply(num1, num2);
                        calci.DisplayResult(num1);
                        break;

                    default:
                        Console.WriteLine("Invalid Operator or Number");
                        break;
                }
                Operator = Console.ReadLine();

            }
        }
        static void Main(string[] args)
        {
            //Calculator();

            Phonebook();
        }
        static void Phonebook()
        {
            List<PhoneBook> myContacts = new List<PhoneBook>();
            
            Console.WriteLine("Press A to Add Contact and Q for Quit");
            string option = Console.ReadLine();
            

            while (option != "Q")
            {
                

                if (option == "A")
                {
                    PhoneBook Inforamtion = new PhoneBook();
                    Console.Write("Name : ");
                    Inforamtion.name = Console.ReadLine();
                    Console.Write("Phone No. : ");
                    Inforamtion.phone = Console.ReadLine();
                    Console.Write("State : ");
                    Inforamtion.state = Console.ReadLine();
                    Console.Write("City : ");
                    Inforamtion.city = Console.ReadLine();
                    Console.WriteLine("----");
                    myContacts.Add(Inforamtion);

                }

                else if (option == "Q")
                {
                    break;
                }

                else
                {
                    Console.WriteLine("Invalid Option");
                }

                Console.WriteLine("Enter Your Options");
                option = Console.ReadLine();

            }

            /* myContacts.Insert(2, new Contact
             {
                 Name = "Ajay",
                 phone = "121121211",
                 state = "Haryana",
                 city = "Yamunanagar"

             });*/


            /*myContacts.Remove(myContacts[1]);*/
            Console.WriteLine("^^^^^^^^L^^^^^^^^");
            Console.WriteLine("^^^^^^^^O^^^^^^^^");
            Console.WriteLine("^^^^^^^^A^^^^^^^^");
            Console.WriteLine("^^^^^^^^D^^^^^^^^");
            Console.WriteLine("^^^^^^^^I^^^^^^^^");
            Console.WriteLine("^^^^^^^^N^^^^^^^^");
            Console.WriteLine("^^^^^^^^Q^^^^^^^^");


            Console.WriteLine("==========================================Your Contacts=========================================");

            foreach (PhoneBook Contact in myContacts)
            {
                Console.Write("Name : ");
                Console.WriteLine(Contact.name);
                Console.Write("Phone No. : ");
                Console.WriteLine(Contact.phone);
                Console.Write("State : ");
                Console.WriteLine(Contact.state);
                Console.Write("City : ");
                Console.WriteLine(Contact.city);
                Console.WriteLine("**************************************");
            }
        } 
    }
}
