using System;
using System.Collections;

namespace _151117_BitMaskBigdan
{
    class Program
    {
        static void Main(string[] args)
        {
            int exit = 0;
            string day;

            while (exit == 0)
            {
                int exit1 = 0;
                int MON = 0;
                int TUE = 0;
                int WED = 0;
                int THU = 0;
                int FRI = 0;
                int SAT = 0;
                int SUN = 0;
                int days = MON | TUE | WED | THU | FRI | SAT | SUN;
                int tasks_mon = 0;
                int tasks_tue = 0;
                int tasks_wed = 0;
                int tasks_thu = 0;
                int tasks_fri = 0;
                int tasks_sat = 0;
                int tasks_sun = 0;

                Console.Clear();

                Console.WriteLine("   /\\_/\\");
                Console.WriteLine("  /`   '\\");
                Console.WriteLine(" === 0  0 ===");
                Console.WriteLine("  \\  --  /");
                Console.WriteLine("  /       \\");
                Console.WriteLine(" /         \\");
                Console.WriteLine("|           |");
                Console.WriteLine(" \\  ||  ||  /");
                Console.WriteLine("  \\_oo__oo_/#######o \n");

                Console.WriteLine("Добрый день!");
                Console.WriteLine("Вы наслаждаетесь видом второго домашнего задания,");
                Console.WriteLine("выполненного Ростиславом Бигданом!");
                Console.ReadKey();

                while (exit1 == 0)
                {
                    Console.Clear();
                    Console.WriteLine("Будьте так любезны, введите день, в который у вас есть задачи:");

                    day = Console.ReadLine();

                    if (day.Contains("Понедельник"))
                    {
                        Console.WriteLine("Введите количество задач:");

                        bool result = Int32.TryParse(Console.ReadLine(), out tasks_mon);
                        if (result)
                        {
                            MON = tasks_mon;
                            days |= MON;

                            Console.WriteLine("Вы добавили {0} задач для понедельника", tasks_mon);

                            Console.WriteLine("Чтобы повторить введите 1, для выхода введите 2");

                            int choice = Convert.ToInt32(Console.ReadLine());
                            if (choice == 1)
                            {
                                exit1 = 0;
                            }
                            if (choice == 2)
                            {
                                exit1 = 1;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Вы ввели что то не то.");
                            Console.WriteLine("Чтобы повторить введите 1, для выхода введите 2");

                            int choice = Convert.ToInt32(Console.ReadLine());
                            if (choice == 1)
                            {
                                exit1 = 0;
                            }
                            if (choice == 2)
                            {
                                exit1 = 1;
                            }
                        }
                    }
                    else
                    {
                        if (day.Contains("Вторник"))
                        {
                            Console.WriteLine("Введите количество задач:");

                            bool result = Int32.TryParse(Console.ReadLine(), out tasks_tue);
                            if (result)
                            {
                                TUE = tasks_tue;
                                days |= TUE;

                                Console.WriteLine("Вы добавили {0} задач для вторника", tasks_tue);

                                Console.WriteLine("Чтобы повторить введите 1, для выхода введите 2");

                                int choice = Convert.ToInt32(Console.ReadLine());
                                if (choice == 1)
                                {
                                    exit1 = 0;
                                }
                                if (choice == 2)
                                {
                                    exit1 = 1;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Вы ввели что то не то.");
                                Console.WriteLine("Чтобы повторить введите 1, для выхода введите 2");

                                int choice = Convert.ToInt32(Console.ReadLine());
                                if (choice == 1)
                                {
                                    exit1 = 0;
                                }
                                if (choice == 2)
                                {
                                    exit1 = 1;
                                }
                            }
                        }
                        else
                        {
                            if (day.Contains("Среда"))
                            {
                                Console.WriteLine("Введите количество задач:");

                                bool result = Int32.TryParse(Console.ReadLine(),out tasks_wed);
                                if (result)
                                {
                                    WED = tasks_wed;
                                    days |= WED;

                                    Console.WriteLine("Вы добавили {0} задач для среды", tasks_wed);

                                    Console.WriteLine("Чтобы повторить введите 1, для выхода введите 2");

                                    int choice = Convert.ToInt32(Console.ReadLine());
                                    if (choice == 1)
                                    {
                                        exit1 = 0;
                                    }
                                    if (choice == 2)
                                    {
                                        exit1 = 1;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Вы ввели что то не то.");
                                    Console.WriteLine("Чтобы повторить введите 1, для выхода введите 2");

                                    int choice = Convert.ToInt32(Console.ReadLine());
                                    if (choice == 1)
                                    {
                                        exit1 = 0;
                                    }
                                    if (choice == 2)
                                    {
                                        exit1 = 1;
                                    }
                                }
                            }
                            else
                            {
                                if (day.Contains("Четверг"))
                                {
                                    Console.WriteLine("Введите количество задач:");

                                    bool result = Int32.TryParse(Console.ReadLine(), out tasks_thu);
                                    if (result)
                                    {
                                        THU = tasks_thu;
                                        days |= THU;

                                        Console.WriteLine("Вы добавили {0} задач для четверга", tasks_thu);

                                        Console.WriteLine("Чтобы повторить введите 1, для выхода введите 2");

                                        int choice = Convert.ToInt32(Console.ReadLine());
                                        if (choice == 1)
                                        {
                                            exit1 = 0;
                                        }
                                        if (choice == 2)
                                        {
                                            exit1 = 1;
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Вы ввели что то не то.");
                                        Console.WriteLine("Чтобы повторить введите 1, для выхода введите 2");

                                        int choice = Convert.ToInt32(Console.ReadLine());
                                        if (choice == 1)
                                        {
                                            exit1 = 0;
                                        }
                                        if (choice == 2)
                                        {
                                            exit1 = 1;
                                        }
                                    }
                                }
                                else
                                {
                                    if (day.Contains("Пятница"))
                                    {
                                        Console.WriteLine("Введите количество задач:");

                                        bool result = Int32.TryParse(Console.ReadLine(), out tasks_fri);
                                        if (result)
                                        {
                                            FRI = tasks_fri;
                                            days |= FRI;

                                            Console.WriteLine("Вы добавили {0} задач для пятницы", tasks_fri);

                                            Console.WriteLine("Чтобы повторить введите 1, для выхода введите 2");

                                            int choice = Convert.ToInt32(Console.ReadLine());
                                            if (choice == 1)
                                            {
                                                exit1 = 0;
                                            }
                                            if (choice == 2)
                                            {
                                                exit1 = 1;
                                            }
                                        }
                                        else
                                        {
                                            Console.WriteLine("Вы ввели что то не то.");
                                            Console.WriteLine("Чтобы повторить введите 1, для выхода введите 2");

                                            int choice = Convert.ToInt32(Console.ReadLine());
                                            if (choice == 1)
                                            {
                                                exit1 = 0;
                                            }
                                            if (choice == 2)
                                            {
                                                exit1 = 1;
                                            }
                                        }
                                    }
                                    else
                                    {
                                        if (day.Contains("Суббота"))
                                        {
                                            Console.WriteLine("Введите количество задач:");

                                            bool result = Int32.TryParse(Console.ReadLine(), out tasks_sat);
                                            if (result)
                                            {
                                                SAT = tasks_sat;
                                                days |= SAT;

                                                Console.WriteLine("Вы добавили {0} задач для субботы", tasks_sat);

                                                Console.WriteLine("Чтобы повторить введите 1, для выхода введите 2");

                                                int choice = Convert.ToInt32(Console.ReadLine());
                                                if (choice == 1)
                                                {
                                                    exit1 = 0;
                                                }
                                                if (choice == 2)
                                                {
                                                    exit1 = 1;
                                                }
                                            }
                                            else
                                            {
                                                Console.WriteLine("Вы ввели что то не то.");
                                                Console.WriteLine("Чтобы повторить введите 1, для выхода введите 2");

                                                int choice = Convert.ToInt32(Console.ReadLine());
                                                if (choice == 1)
                                                {
                                                    exit1 = 0;
                                                }
                                                if (choice == 2)
                                                {
                                                    exit1 = 1;
                                                }
                                            }
                                        }
                                        else
                                        {
                                            if (day.Contains("Воскресенье"))
                                            {
                                                Console.WriteLine("Введите количество задач:");

                                                bool result = Int32.TryParse(Console.ReadLine(), out tasks_sun);
                                                if (result)
                                                {
                                                    SUN = tasks_sun;
                                                    days |= SUN;

                                                    Console.WriteLine("Вы добавили {0} задач для воскресенья", tasks_sun);

                                                    Console.WriteLine("Чтобы повторить введите 1, для выхода введите 2");

                                                    int choice = Convert.ToInt32(Console.ReadLine());
                                                    if (choice == 1)
                                                    {
                                                        exit1 = 0;
                                                    }
                                                    if (choice == 2)
                                                    {
                                                        exit1 = 1;
                                                    }
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Вы ввели что то не то.");
                                                    Console.WriteLine("Чтобы повторить введите 1, для выхода введите 2");

                                                    int choice = Convert.ToInt32(Console.ReadLine());
                                                    if (choice == 1)
                                                    {
                                                        exit1 = 0;
                                                    }
                                                    if (choice == 2)
                                                    {
                                                        exit1 = 1;
                                                    }
                                                }
                                            }
                                            else
                                            {
                                                Console.WriteLine("Вы ввели что то не то.");
                                                Console.WriteLine("Чтобы повторить введите 1, для выхода введите 2");

                                                int choice = Convert.ToInt32(Console.ReadLine());
                                                if (choice == 1)
                                                {
                                                    exit1 = 0;
                                                }
                                                if (choice == 2)
                                                {
                                                    exit1 = 1;
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                if ((days & MON) != 0)
                {
                    Console.WriteLine("У вас есть {0} задач в понедельник", tasks_mon);
                }
                if ((days & TUE) != 0)
                {
                    Console.WriteLine("У вас есть {0} задач во вторник", tasks_tue);
                }
                if ((days & WED) != 0)
                {
                    Console.WriteLine("У вас есть {0} задач в среду", tasks_wed);
                }
                if ((days & THU) != 0)
                {
                    Console.WriteLine("У вас есть {0} задач в четверг", tasks_thu);
                }
                if ((days & FRI) != 0)
                {
                    Console.WriteLine("У вас есть {0} задач в пятницу", tasks_fri);
                }
                if ((days & SAT) != 0)
                {
                    Console.WriteLine("У вас есть {0} задач в субботу", tasks_sat);
                }
                if ((days & SUN) != 0)
                {
                    Console.WriteLine("У вас есть {0} задач в воскресенье", tasks_sun);
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
