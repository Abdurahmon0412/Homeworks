namespace Homeworks
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var rd = new Random();
            string[,] board = new string[3, 3]
            {
                {"#", "#","#"},
                {"#", "#","#"},
                {"#", "#","#"}
            };
            
            
            Print(board);
            
            Console.WriteLine("Xurmatli Player X bulasizmi yoki 0: ");
            var player = Console.ReadLine().ToUpper();
            string robot;
            if (player == "X")
            {
                robot = "0";
            }
            else
            {
                robot = "X";
            }
            
            
            while (true)
            {
                bool winR = Checked(board, robot);
                var draw = CheckDraw(board);
                if(draw == true)
                {
                    Console.WriteLine("Durrang"); break;
                }
                if (winR)
                {
                    Console.WriteLine("Komputer g'alaba qozondi ");
                    break;
                }
                Print(board);
                while (true)
                {
                    int x = rd.Next(0, 3);
                    int y = rd.Next(0, 3);

                    if (board[x, y] == "#")
                    {
                        board[x, y] = robot;
                        Print(board);
                        break;
                    }
                    else
                    {
                        continue;
                    }
                }

                bool winP = Checked(board, player);
                if (winP)
                {
                    Print(board);
                    Console.WriteLine("Tabriklaymiz siz yutdingiz.");
                    break;
                }

                while (true)
                {
                    Console.WriteLine("qatorni kiriting: ");
                    int px = int.Parse(Console.ReadLine()) - 1;
                    Console.WriteLine("ustunni kiriting: ");
                    int py = int.Parse(Console.ReadLine()) - 1;
                    Print(board);
                    if (board[px, py] == "#")
                    {
                        Print(board);
                        board[px, py] = player;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Bu yer belgilangan boshqa tanlang ");
                    }
                }
                
                

            }
        }
        public static bool Checked(string [,] board, string simbol)
        {
            for (int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    if (board[i,0] == simbol && board[i,1] == simbol && board[i,2] == simbol || board[0,i] == simbol && board[1,0] == simbol && board[2,0] == simbol)
                    {
                        return true;
                    }
                    if (board[0,0] == simbol && board[1,1] == simbol && board[2,2] == simbol || board[0,2]  == simbol && board[1,1] == simbol && board[2,0] == simbol)
                    {
                        return true;
                    }
                }
                
            }
            return false;
        }
        
        public static void Print(string[,] board)
        {
            Console.Clear();
            for (int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    Console.Write(" " + board[i,j] + " ");
                }
                Console.WriteLine();
                Console.WriteLine();

            }
        }
        public static bool CheckDraw(string[,] board)
        {
            int count = 0;
            for (int i = 0; i < 3; i++) 
            {
                for(int k = 0; k < 3; k++)
                {
                    if (board[i,k] == "#")
                    {
                        count++;
                    }
                }
            }
            if (count < 3)
                return true;
            return false;
        }
    }
}


