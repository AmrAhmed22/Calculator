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




        static void Main(string[] args)
        {
           
        }
    }
}
