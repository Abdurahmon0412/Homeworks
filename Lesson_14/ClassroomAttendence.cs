namespace Lesson_14
{
    public class ClassroomAttendence
    {
        protected Dictionary<string, string> Students = new Dictionary<string, string>();


        public void Mark(string fullname, bool IsPresent)
        {
            Students[fullname] = IsPresent ? "present" : "absent";

        }

        internal protected float GetStats()
        {
            var keldi = 0f;
            foreach (var item in Students)
            {
                if (item.Value == "present")
                {
                    keldi++;
                }
            }
            return (keldi / Students.Count) * 100;
        }
        public virtual void Display()
        {
            foreach (var item in Students)
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }
        }
    }

    public class UltimateClassroomAttendence : ClassroomAttendence
    {
        public void Mark(string fullname, bool IsPresent, string cause = "bugun kasal")
        {
            Students[fullname] = IsPresent ? "present" : string.Concat("absent => ", cause);

        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine("Kelgan uquvchilar foizi:");
            Console.WriteLine(GetStats());
        }
    }



}
