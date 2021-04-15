using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Start of program & The restart loop
            bool contiune = true;
            do
            {
                // Varibles and error checks
                string Snum1;
                string Snum2;
                string oper;
                decimal num1;
                decimal num2;
                int Choice;
                int oper1 = 1;
                int oper2 = 2;
                int oper3 = 3;
                int oper4 = 4;
                bool Error1 = true;
                bool Error2 = true;
                bool Error3 = true;
                bool Error4 = true;
                // Number inputs
                do
                {
                    Console.Write("Enter your first number: ");
                    Snum1 = (Console.ReadLine());
                    bool canConvert = decimal.TryParse(Snum1, out num1);
                    if (!canConvert)
                    {
                        Console.WriteLine("Error: U type letter u bum");
                    }
                    else
                    {
                        Error1 = false;
                    }
                        
                } while (Error1);
                do
                {
                    Console.Write("Enter your Second number: ");
                    Snum2 = (Console.ReadLine());
                    bool canConvert = decimal.TryParse(Snum2, out num2);
                    if (!canConvert)
                    {
                        Console.WriteLine("Error: U type letter u bum");
                    }
                    else
                    {
                        Error2 = false;
                    }

                } while (Error2);
                // Answers for equation
                do
                {
                    Console.WriteLine("What operator?\n Divide = 1\n Muitply = 2\n Subtraction = 3\n Addition = 4 ");
                    oper = (Console.ReadLine());
                    bool canConvert = Int32.TryParse(oper, out Choice);
                    if (Choice == oper1)
                    {
                        Error3 = false;
                        Console.WriteLine("The Final answer is " + (num1 / num2));
                    }
                    else if (Choice == oper2)
                    {
                        Error3 = false;
                        Console.WriteLine("The Final answer is " + (num1 * num2));
                    }
                    else if (Choice == oper3)
                    {
                        Error3 = false;
                        Console.WriteLine("The Final answer is " + (num1 - num2));
                    }
                    else if (Choice == oper4)
                    {
                        Error3 = false;
                        Console.WriteLine("The final answer is " + (num1 + num2));
                    }
                    else
                    {
                        Console.WriteLine("Invaild Operator");
                    }
                } while (Error3);
                // Propt to use the calc again
                do
                {
                    Console.WriteLine("Want to use the calculator again?");
                    string restart = (Console.ReadLine());
                    if (restart == "no")
                    {
                        contiune = false;
                        Error4 = false;
                    }
                    else if (restart == "yes")
                    {
                        Error4 = false;
                    }
                    else
                    {
                        Console.WriteLine("Wrong choice, use either yes or no");
                    }
                } while (Error4);
            } while (contiune);
        }
    }
}
