namespace Homeworks
{
    public class Program
    {
        public static void Main(string[] args)
        {
            while(true)
            {
                Console.WriteLine("For Exit: 'e'\\ for continue 'c'");
                string exit = Console.ReadLine();
                if (exit == "e")
                {
                    Console.WriteLine("Thank you");
                    break;
                }
                else
                {


                    int Number1 = GetNumber();
                    string charakter = GetOperator();
                    int Number2 = GetNumber();

                    switch (charakter)
                    {
                        case "/":
                            Console.Write("Result: ");
                            Console.WriteLine(Number1 / Number2);
                            break;
                        case "*":
                            Console.Write("Result: ");
                            Console.WriteLine(Number1 * Number2);
                            break;
                        case "+":
                            Console.Write("Result: ");
                            Console.WriteLine(Number1 + Number2);
                            break;
                        case "-":
                            Console.Write("Result: ");
                            Console.WriteLine(Number1 - Number2);
                            break;
                        case "%":
                            Console.WriteLine(Number1 % Number2);
                            break;
                    }
                }
            }
        }
        public static int GetNumber()
        {
            int number;
            bool check;
            do
            {
                Console.WriteLine("Enter any Number: ");
                check = int.TryParse(Console.ReadLine(), out number);
            } while (!check);
            return number;
        }

        public static string GetOperator()
        {
            do
            {
                Console.WriteLine("Enter Command: ");
                string operators = Console.ReadLine();
                switch (operators)
                {
                    case "*":
                        return operators;
                        break;
                    case "/":
                        return operators;
                        break;
                    case "+":
                        return operators;
                        break;
                    case "-":
                        return operators;
                        break;
                    case "%":
                        return operators;
                    case "e":
                        return operators;
                }
            } while (true);
        }
    }
}