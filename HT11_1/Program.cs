using HT11_1;
using System.Diagnostics;
using System.Threading.Tasks;

namespace Homeworks
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var TaskList = new ToDoList();
            DefaultTask(ref TaskList);
            while (true)
            {
                Console.WriteLine("Choose a command\n(display all) - d");
                Console.WriteLine("(mark done) - m\n(add) - a");

                var check = Console.ReadLine().ToLower();
                if(string.IsNullOrEmpty(check) || string.IsNullOrWhiteSpace(check))
                    Console.WriteLine("iltimos komandani tugri kiriting");
                switch (check)
                {
                    case "d":
                        TaskList.Display();
                        break;
                    case "m":
                        Console.Clear();
                        TaskList.MarkDone();
                        break;
                    case "a":
                        Console.Clear();
                        TaskList.Display();
                        Console.WriteLine("Enter task name");
                        var task = new ToDo(Console.ReadLine());
                        TaskList.Add(task);
                        break;
                    default:
                        Console.WriteLine("Bunday komanda mavjud emas");
                        break;
                }
            }
        }

        public static void DefaultTask(ref ToDoList TaskList)
        {
            var task1 = new ToDo("hometask");
            var task2 = new ToDo("English course");
            var task3 = new ToDo("sleep");
            TaskList.Add(task1);
            TaskList.Add(task2);
            TaskList.Add(task3);
        }

        
    }
}




