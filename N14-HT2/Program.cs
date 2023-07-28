using Lesson_14;
namespace N14_HT2
{
    class Program
    {
        static void Main(string[] args)
        {

            var Admin = new UltimateClassroomAttendence();

                Admin.Mark("Quzivoy", true);
                Admin.Mark("Eshmat", true);
                Admin.Mark("Aziza", false, "Yunalishini uzgartirgan");
                Admin.Mark("Jasur", true);
                Admin.Mark("Firdavs", false, "Game turniri bor");
                Admin.Display();
        }
    }
}