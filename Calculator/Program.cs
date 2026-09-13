namespace Calculator
{
    internal class Program
    {
        static double Get_Valid_num(string message = "\nError: Please Enter a valid number.\n")
        {

            while (true)
            {
               

                if (double.TryParse(Console.ReadLine(), out double number))
                {
                    return number;
                }

                Console.Write(message);
            }
        }

        static string Get_Valid_Operator(string message = "\nError: Please Enter a valid operator.\n")
        {
            
            while (true)
            {
                
                string op = Console.ReadLine()?.Trim();

                if (op == "+" || op == "-" || op == "*" || op == "/")
                {
                    return op;
                }
                Console.Write(message);
            }
        }


        static double Add(double num1,double num2)
        {
            return num1 + num2;
        }

        static double Subtract(double num1, double num2)
        {
            return num1 - num2;
        }

        static double Multiply(double num1, double num2)
        {
            return num1 * num2;
        }

        static double Divide(double num1, double num2)
        {
            return num1 / num2;
        }


        static void CalcHandler(double num1, double num2, string op)
        {
            double res = 0;
            switch (op)
            {
                case "+":
                    res = Add(num1, num2);               
                    break;
                case "-":
                    res = Subtract(num1, num2);
                    break;
                case "*":
                    res = Multiply(num1, num2);
                    break;
                case "/":
                    res = Divide(num1, num2);
                    break;

            }

            Console.WriteLine($"Result: {num1} {op} {num2} = {res}");
        }

        static void Main(string[] args)
        {
            bool calc_again = true;
            Console.WriteLine("--- Calculator ---");


            while (calc_again)
            {

                Console.WriteLine("\nEnter the first number: ");
                double num1 = Get_Valid_num();


                Console.WriteLine("Enter the operator (+, -, *, /): ");
                string op = Get_Valid_Operator();


                Console.WriteLine("\nEnter the second number: ");
                double num2 = Get_Valid_num();

                
                
                CalcHandler(num1, num2, op);


                Console.Write("\nWould you like to perform another calculation? (y/n): ");
                if (Console.ReadLine()?.Trim().ToLower() != "y")
                {
                    calc_again = false;
                }
            }
        }
    }
}
