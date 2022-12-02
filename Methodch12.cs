using System;
namespace Ch12Method
{
    class Program
    {
        static void Main(string[] args)
        {
            //accepting two number
            //accepting operator (+-*%/)
            //Calculate two number depending  on user
            //show result 
            try
            {
                Console.Write(" Enter a number (1) : ");
                int number1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter a number (2) : ");
                int number2 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter operator ( + , - , * , /, % ) : ");
                string operators = Console.ReadLine();
                if (operators == "+" || operators == "-" || operators == "*" || operators == "/" ||
                    operators == "%")
                {
                    if (operators == "+")
                    {
                        int sumtwonumber = twonumbersadd(number1, number2);
                        Console.WriteLine($"The result of number(1) + number (2) : { sumtwonumber}");
                    }
                    else if (operators == "-")
                    {
                        int subtwonumber = twonumbersub(number1, number2);
                        Console.WriteLine($"The result of number(1) - number (2) : { subtwonumber}");
                    }
                    else if (operators == "*")
                    {
                        int multitwonumber = twonumbermulti(number1, number2);
                        Console.WriteLine($"The result of number (1) * number(2) : {multitwonumber} ");
                    }
                    else if (operators == "/")
                    {
                        int divisiontwonumber = twonumberdivision(number1, number2);
                        Console.WriteLine($"The reault of number (1) /number(2) : {divisiontwonumber} ");
                    }
                    else if (operators == "%")
                    {
                        int twonumberdivision1 = divisiontwonumber1(number1, number2);
                        Console.WriteLine($"The reault of number (1) %number(2) : {twonumberdivision1} ");
                    }
                }
                else
                {
                    throw new ArgumentException("Your typing must be operators(+ - % / *) ");
                }
            }
            catch (FormatException e1)
            {
                Console.WriteLine("Your inputing must be number");
            }
            catch (Exception e2)
            {
                Console.WriteLine("Error !!! Your Typing must be operators (+ * / % -)");
            }
            Console.WriteLine("Press any key to close the window");
            Console.ReadKey();
        }
        static int twonumbersadd(int number1, int number2)
        {
            int sumtwonumber = number1 + number2;
            return sumtwonumber;
        }
        static int twonumbersub(int number1, int number2)
        {
            int subtwonumber = number1 - number2;
            return subtwonumber;
        }
        static int twonumbermulti(int number1, int number2)
        {
            int multinumber = number1 * number2;
            return multinumber;
        }
        static int twonumberdivision(int number1, int number2)
        {
            int divisiontwonumber = number1 / number2;
            return divisiontwonumber;
        }
        static int divisiontwonumber1(int number1, int number2)
        {
            int twonumberdivision1 = number1 % number2;
            return twonumberdivision1;
        }

    }
}
