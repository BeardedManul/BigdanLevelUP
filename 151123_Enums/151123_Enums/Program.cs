using System;

namespace _151123_Enums
{
    class Program
    {
        enum Week : int
        {
            Empty = 0,
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }

        [Flags]
        enum WeekFlag : int
        {
            Empty = 0,
            Monday = 1,
            Tuesday = 2,
            Wednesday = 4,
            Thursday = 8,
            Friday = 16,
            Saturday = 32,
            Sunday = 64
        }

        static void Main(string[] args)
        {
            int exit = 0;
            Week w = new Week();
            WeekFlag wf = new WeekFlag();
            char[] delimiterChars = { ' ', ',', '.' };

            while (exit == 0)
            {
                Console.WriteLine("В какие дни у вас есть занятия?");
                string days_source = Console.ReadLine();
                string days = days_source.ToUpper();

                string[] days_split = days.Split(delimiterChars);

                for (int i = 0; i < days_split.Length; i++)
                {
                    switch (days_split[i])
                    {
                        case "ПОНЕДЕЛЬНИК":
                            w = Week.Monday;
                            wf = WeekFlag.Monday;
                            break;

                        case "ВТОРНИК":
                            w = Week.Tuesday;
                            wf = WeekFlag.Tuesday;
                            break;

                        case "СРЕДА":
                            w = Week.Wednesday;
                            wf = WeekFlag.Wednesday;
                            break;

                        case "ЧЕТВЕРГ":
                            w = Week.Thursday;
                            wf = WeekFlag.Thursday;
                            break;

                        case "ПЯТНИЦА":
                            w = Week.Friday;
                            wf = WeekFlag.Friday;
                            break;

                        case "СУББОТА":
                            w = Week.Saturday;
                            wf = WeekFlag.Saturday;
                            break;

                        case "ВОСКРЕСЕНЬЕ":
                            w = Week.Sunday;
                            wf = WeekFlag.Sunday;
                            break;

                        default:
                            break;
                    }

                    switch (w)
                    {
                        case Week.Monday:
                            Console.WriteLine("У вас есть занятия в понедельник");
                            break;
                        case Week.Tuesday:
                            Console.WriteLine("У вас есть занятия во вторник");
                            break;
                        case Week.Wednesday:
                            Console.WriteLine("У вас есть занятия в среду");
                            break;
                        case Week.Thursday:
                            Console.WriteLine("У вас есть занятия в четверг");
                            break;
                        case Week.Friday:
                            Console.WriteLine("У вас есть занятия в пятницу");
                            break;
                        case Week.Saturday:
                            Console.WriteLine("У вас есть занятия в субботу");
                            break;
                        case Week.Sunday:
                            Console.WriteLine("У вас есть занятия в воскресенье");
                            break;
                        case Week.Empty:
                        default:
                            break;
                    }

                    if ((wf.HasFlag(WeekFlag.Monday)))
                    {
                        Console.WriteLine("У вас есть занятия в понедельник");
                    }
                    if ((wf.HasFlag(WeekFlag.Tuesday)))
                    {
                        Console.WriteLine("У вас есть занятия во вторник");
                    }
                    if ((wf.HasFlag(WeekFlag.Wednesday)))
                    {
                        Console.WriteLine("У вас есть занятия в среду");
                    }
                    if ((wf.HasFlag(WeekFlag.Thursday)))
                    {
                        Console.WriteLine("У вас есть занятия в четверг");
                    }
                    if ((wf.HasFlag(WeekFlag.Friday)))
                    {
                        Console.WriteLine("У вас есть занятия в пятницу");
                    }
                    if ((wf.HasFlag(WeekFlag.Saturday)))
                    {
                        Console.WriteLine("У вас есть занятия в субботу");
                    }
                    if ((wf.HasFlag(WeekFlag.Sunday)))
                    {
                        Console.WriteLine("У вас есть занятия в воскресенье");
                    }
                }

                Console.ReadKey();
                Console.WriteLine("Чтобы повторить введите 1, для выхода введите 2");

                int choice1 = Convert.ToInt32(Console.ReadLine());
                if (choice1 == 1)
                {
                    exit = 0;
                }
                if (choice1 == 2)
                {
                    exit = 1;
                }
            }
        }
    }
}
