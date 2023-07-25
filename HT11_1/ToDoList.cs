using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HT11_1
{
    public class ToDoList
    {
        public List<ToDo> todolist = new List<ToDo>();


        public void Display()
        {
            Console.Clear();
            int i = 0;
            foreach (var todo in todolist)
            {
                i++;
                Console.WriteLine(i + "." + todo.TaskName);
            }
    }

        public void MarkDone()
        {
            Console.WriteLine("choose which task");
            Display();
            var j = Convert.ToInt32(Console.ReadLine());
            if (todolist[j-1].Isdone == false)
            {
                todolist[j - 1].Isdone = true;
                Console.WriteLine("Task:  " + todolist[j - 1].TaskName + "  marked as done");
            }
            
        }


        public void Add(ToDo task)
        {
            todolist.Add(task);
        }
    }

}
