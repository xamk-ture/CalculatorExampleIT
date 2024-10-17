namespace CalculatorExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Console.WriteLine("Select operation: 1: Sum, 2: Substract, 3: Divide");

            double result = 0;

            //Ask operation
            int operation = AskOperation();

            //ask number
            Console.WriteLine("Input number 1");
            int number1 = AskNumber();

            //ask number 2
            Console.WriteLine("Input number 2");
            int number2 = AskNumber();


            //Example how to ask number another way. This variable is not used in code otherwise
            int num3 = AskNumberAnotherWay("Please input number 3");

            //Calclute result and pass the parameters it needs
            result = Caclulate(operation, number1, number2);

            //Print result
            PrintResult(operation, number1, number2, result);

            //Another way to print result. In here we get the result text in a string variable
            //and then we
            string resultText = GetResultText(operation, number1, number2, result);

            Console.WriteLine(resultText);
        }

        static string GetResultText(int operation, int a, int b, double result)
        {
            char operationChar = GetOperationChar(operation);
            string printText = $"Result: {a} {operationChar} {b} = {result}";

            return printText;
        }

        static void PrintResult(int operation, int a, int b, double result)
        {
            char operationChar = GetOperationChar(operation);
            Console.WriteLine($"Result: {a} {operationChar} {b} = {result}");
        }

        /// <summary>
        /// Function that returns operation symbol based on operation number
        /// For example 1 = + etc
        /// </summary>
        /// <param name="operation"></param>
        /// <returns></returns>
        static char GetOperationChar(int operation)
        {
            char operationChar = ' ';

            if (operation == 1)
            {
                operationChar = '+';
            }
            else if (operation == 2)
            {
                operationChar = '-';
            }
            else if (operation == 3)
            {
                operationChar = '/';
            }

            return operationChar;
        }

        //Try catch demo not used in code
        static int DivideWithTryCatch(int a, int b)
        {
            int?[] numbers = { 0, 1, 2, null };

            int result = 0;

            string demo = "ss";
            string? nullDemo = null;

            try
            {
                Console.WriteLine("Test");
                int.Parse("s");
                //Dividing by zero could crash this software
                result = a / b;
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Trying to divide by zero");
            }
            catch(FormatException e)
            {
                Console.WriteLine("Format exceptin not a number");
            }
            finally
            {
                Console.WriteLine("Finally block is that will always be executed" +
                    "even if the program does not go to catch block");
            }

            return result;
        }


        static int Sum(int a, int b)
        {
            return a + b;
        }

        static int Substr(int a, int b)
        {
            return (a - b);
        }

        static double? Divide(double a, double b)
        {
            if(a == 0 || b == 0)
            {
                //This value represents attempt of trying to divide by zero
                return null;
            }

            return a / b;
        }

        /// <summary>
        /// This calculates results based on user operation and numbers
        /// </summary>
        /// <param name="operation"></param>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        static double Caclulate(int operation, int a, int b)
        {
            double result = 0;

            if(operation == 1)
            {
                //Sum
                result = Sum(a, b);
            }
            else if(operation == 2) 
            {
                 //Substract

                result = Substr(a, b);
            }
            else if(operation == 3)
            {
                //Divide


                //Another way to do
                if(a == 0 || b == 0)
                {
                    Console.WriteLine("You cannot divide by zero");

                    return 0;
                }

                double? divideResult = Divide(a, b);

                if(divideResult == null)
                {
                    Console.WriteLine("You cannot divide by zero");
                }
            }


            return result;
        }

        static int AskNumberAnotherWay(string infoText)
        {
            Console.WriteLine(infoText);

            int number = 0;

            while (true)
            {
                string userInput = Console.ReadLine();

                if (!int.TryParse(userInput, out number))
                {
                    Console.WriteLine("Please input number");
                    continue;
                }

                break;
            }

            return number;
        }

        static int AskNumber()
        {
            int number = 0;

            while (true)
            {
                string userInput = Console.ReadLine();

                if (!int.TryParse(userInput, out number))
                {
                    Console.WriteLine("Please input number");
                    continue;
                }

                break;
            }

            return number;
        }


        static int AskOperation()
        {
            int operation = 0;

            while (true)
            {
                string userInput = Console.ReadLine();

                if(!int.TryParse(userInput, out operation))
                {
                    Console.WriteLine("Please input number");
                    continue;
                }

                if(operation <= 0 || operation >= 4)
                {
                    Console.WriteLine("Please give operation number that is in range 1-4");
                    continue;
                }

                break;
            }

            return operation;
        }
    }
}
