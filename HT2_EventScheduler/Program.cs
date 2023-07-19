using System;
using System.Collections.Immutable;

string[] EventNames = new string[]
{
    "Zakovat",
    "Tugilgan kunim",
    "Frontend Musobaqa",
    "Algoritmlash musobaqasi",
    "Imtihon",
    "Marketing musobaqasi",
    "Ingliz tili imtihon",
    "Dizayn musobaqa",
    "Hayit",
    "Saylov"
};
#region
DateTime[] EventTime = new DateTime[10];

EventTime[0] = new DateTime(2025, 7, 12);
EventTime[1] = new DateTime(2015, 5, 15);
EventTime[2] = new DateTime(2022, 7, 12);
EventTime[3] = new DateTime(2024, 3, 27);
EventTime[4] = new DateTime(2011, 12, 17);
EventTime[5] = new DateTime(1926, 9, 15);
EventTime[6] = new DateTime(2014, 12, 12);
EventTime[7] = new DateTime(2003, 5, 31);
EventTime[8] = new DateTime(2022, 7, 19);
EventTime[9] = new DateTime(2023, 8, 13);
#endregion
int h = 0;
bool exit = true;
while (true)
{
    if (!exit) break;
    Console.WriteLine("Buyruq raqamini kiriting: ");
    Console.Write("\tMeny");
    Console.WriteLine(@" 
    eventlarni saralash - 1
    eventni nomi bo'yicha topish - 2
    eventni vaqti bo'yicha topish - 3
    kelayotgan eventlarni ko'rsatish - 4
    o'tib ketgan eventlarni ko'rsatish - 5
    kelayotgan eventlarni ko'rsatish ( yaqinligi bo'yicha) - 6
    o'tib ketgan eventlarni ko'rsatish ( yaqinligi bo'yicha ) - 7
    dasturni yopish - 8");

    var choose = Console.ReadLine();
    if (String.IsNullOrEmpty(Convert.ToString(choose)))
    {
        Console.WriteLine("Amalni Tanlang");
    }
    Console.WriteLine();
    switch (choose)
    {
        case "1":
            Console.Clear();
            Console.WriteLine("Saralash turini tanlang:\n 1.Event nomi buyicha\n 2.Event vaqti buyicha");
            var choose1_2 = Console.ReadKey().KeyChar;
            switch (choose1_2)
            {
                case '1':
                    for(int nameA = 0; nameA < EventNames.Length; nameA++)
                    {
                        for(int nameB = 0;nameB < EventNames.Length;nameB++)
                        {
                            if (EventNames[nameA].CompareTo(EventNames[nameB]) == -1)
                            {
                                var tempname = EventNames[nameA];
                                EventNames[nameA] = EventNames[nameB];
                                EventNames[nameB] = tempname;

                                var temptime = EventTime[nameA];
                                EventTime[nameA] = EventTime[nameB];
                                EventTime[nameB] = temptime;
                            }
                        }
                    }
                    Console.WriteLine();
                    for (int nameA = 0; nameA < EventTime.Length; nameA++)
                    {
                        Console.WriteLine(EventNames[nameA] + " - " + EventTime[nameA] + "da");
                    }

                    break;
                case '2':
                    for (int timeA = 0; timeA < EventTime.Length - 1; timeA++)
                    {
                        for (int timeB = timeA; timeB < EventTime.Length; timeB++)
                        {
                            if (EventTime[timeA].DayOfYear > EventTime[timeB].DayOfYear)
                            {
                                var tempName = EventNames[timeA];
                                EventNames[timeA] = EventNames[timeB];
                                EventNames[timeB] = tempName;

                                var temp = EventTime[timeA];
                                EventTime[timeA] = EventTime[timeB];
                                EventTime[timeB] = temp;
                            }
                        }
                    }
                    for (int timeA = 0;timeA < EventNames.Length;timeA++)
                    {
                        Console.WriteLine(EventNames[timeA] + " - " + EventTime[timeA] + "da");
                    }
                    break;
            }
            break;
        case "2":
            Console.Clear();
            Console.WriteLine("Izlayotgan eventingizni kiriting: ");
            var searchInput = Console.ReadLine();
            int searchcount = 0;
            for (int searchEvent = 0; searchEvent < EventNames.Length; searchEvent++)
            {
                if (EventNames[searchEvent].Contains(searchInput))
                {
                    searchcount++;
                    Console.WriteLine($"{EventNames[searchEvent]} - {EventTime[searchEvent]} da.");
                }
            }
            if (searchcount < 1)
                Console.WriteLine("Uzur bunday Event topilmadi");
            Thread.Sleep(3000);
            break;
        case "3":
            System.Console.Clear();
            Console.WriteLine("Izlayotgan Eventingizni vaqtini kiriting: ");
            
            var searchtime = Convert.ToString(Console.ReadLine());
            for (var searchEvent = 0; searchEvent < EventTime.Length; searchEvent++)
            {
                if (Convert.ToString(EventTime[searchEvent]).Contains(Convert.ToString(searchtime)))
                {
                    Console.WriteLine($"{EventNames[searchEvent]} - {EventTime[searchEvent]} da.");
                }
            }

            Thread.Sleep(3000);
            break;
        case "4":
            Console.Clear();
            Console.WriteLine("Kelayotgan Eventlar: ");
            for (var searchEvent = 0; searchEvent < EventTime.Length; searchEvent++)
            {
                if (EventTime[searchEvent].DayOfYear > DateTime.Now.DayOfYear)
                {
                    Console.WriteLine($"{EventNames[searchEvent]} - {EventTime[searchEvent]} da.");
                }
            }
            Thread.Sleep(3000);
            break;
        case "5":
            Console.Clear();
            Console.WriteLine("Utib ketgan Eventlar: ");
            for (var searchEvent = 0; searchEvent < EventTime.Length; searchEvent++)
            {
                if (EventTime[searchEvent].DayOfYear < DateTime.Now.DayOfYear)
                {
                    Console.WriteLine($"{EventNames[searchEvent]} - {EventTime[searchEvent]} da edi.");
                }
            }
            Thread.Sleep(3000);
            break;
        case "6":
            Console.Clear();
            DateTime[] sorts = new DateTime[1];
            string[] names = new string[1];
            int resize = 0;
            for (var searchEvent = 0; searchEvent < EventTime.Length; searchEvent++)
            {
                if (EventTime[searchEvent].DayOfYear > DateTime.Now.DayOfYear)
                {
                    Array.Resize(ref sorts, sorts.Length + 1);
                    Array.Resize(ref names, names.Length + 1);
                    names[resize] = EventNames[searchEvent];
                    sorts[resize] = EventTime[searchEvent];
                    resize++;
                }
            }
            Array.Resize(ref sorts, sorts.Length - 1);
            Array.Resize(ref names, names.Length - 1);
            for (int sortEventA = 0; sortEventA < sorts.Length; sortEventA++)
            {
                for (int sortEventB = 0; sortEventB < sorts.Length; sortEventB++)
                {
                    if (sorts[sortEventA].DayOfYear < sorts[sortEventB].DayOfYear)
                    {
                        var tempName = names[sortEventA];
                        names[sortEventA] = names[sortEventB];
                        names[sortEventB] = tempName;

                        var temp = sorts[sortEventA];
                        sorts[sortEventA] = sorts[sortEventB];
                        sorts[sortEventB] = temp;
                    }
                }
            }
            for (int i = 0; i < sorts.Length - 1; i++)
            {
                Console.WriteLine($"{names[i]} - {sorts[i]} da edi.");
            }
            break;
        case "7":
            Console.Clear();
            DateTime[] sortsB = new DateTime[1];
            string[] namesB = new string[1];
            int resizeB = 0;
            for (var searchEvent = 0; searchEvent < EventTime.Length; searchEvent++)
            {
                if (EventTime[searchEvent].DayOfYear < DateTime.Now.DayOfYear)
                {
                    Array.Resize(ref sortsB, sortsB.Length + 1);
                    Array.Resize(ref namesB, namesB.Length + 1);
                    namesB[resizeB] = EventNames[searchEvent];
                    sortsB[resizeB] = EventTime[searchEvent];
                    resizeB++;
                }
            }
            Array.Resize(ref sortsB, sortsB.Length - 1);
            Array.Resize(ref namesB, namesB.Length - 1);
            for (int sortEventA = 0; sortEventA < sortsB.Length; sortEventA++)
            {
                for (int sortEventB = 0; sortEventB < sortsB.Length; sortEventB++)
                {
                    if (sortsB[sortEventA].DayOfYear > sortsB[sortEventB].DayOfYear)
                    {
                        var tempName = namesB[sortEventA];
                        namesB[sortEventA] = namesB[sortEventB];
                        namesB[sortEventB] = tempName;

                        var temp = sortsB[sortEventA];
                        sortsB[sortEventA] = sortsB[sortEventB];
                        sortsB[sortEventB] = temp;
                    }
                }
            }
            for (int i = 0; i < sortsB.Length - 1; i++)
            {
                Console.WriteLine($"{namesB[i]} - {sortsB[i]} da edi.");
            }
            break;
        case "8":
            Console.WriteLine("\nThank you!");
            exit = false;
            break;
        default:
            Console.Clear();
            Console.WriteLine("Bunday belgi qabul qilinmaydi");
            break;
    }


}