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

        static void Main(string[] args)
        {
            int exit = 0;   //Пока равна 0 работает основной цикл
            string day;
            Week w = Week.Empty;
            Week[] w1 = new Week[7];
            int[] tasks = new int[7];

            while (exit == 0)
            {
                      //Пока равна 0 работает цикл ввода дня

                //Переменные, отвечающие за количество задач

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

                
                for (int i = 0; i < 6; i++)
                {
                    Console.Clear();
                    Console.WriteLine("Будьте так любезны, введите день, в который у вас есть задачи:");

                    day = Console.ReadLine();

                    if (day.Contains("Понедельник"))
                    {
                        Console.WriteLine("Введите количество задач:");

                        bool result = Int32.TryParse(Console.ReadLine(), out tasks[i]);
                        if (result)
                        {
                            w1[i] = Week.Monday;

                            Console.WriteLine("Вы добавили {0} задач для понедельника", tasks[i]);

                            Console.WriteLine("Чтобы повторить введите 1, для выхода введите 2");

                            int choice = Convert.ToInt32(Console.ReadLine());
                            if (choice == 1)
                            {
                            Console.WriteLine("Продолжаю...");
                            Console.ReadKey();
                            }
                            if (choice == 2)
                            {
                                i = 6;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Вы ввели что то не то.");
                            Console.WriteLine("Чтобы повторить введите 1, для выхода введите 2");

                            int choice = Convert.ToInt32(Console.ReadLine());
                            if (choice == 1)
                            {
                            Console.WriteLine("Продолжаю...");
                            Console.ReadKey();
                        }
                            if (choice == 2)
                            {
                                i = 6;
                            }
                        }
                    }
                    else
                    {
                        if (day.Contains("Вторник"))
                        {
                            Console.WriteLine("Введите количество задач:");

                            bool result = Int32.TryParse(Console.ReadLine(), out tasks[i]);
                            if (result)
                            {
                                w1[i] = Week.Tuesday;

                                Console.WriteLine("Вы добавили {0} задач для вторника", tasks[i]);

                                Console.WriteLine("Чтобы повторить введите 1, для выхода введите 2");

                                int choice = Convert.ToInt32(Console.ReadLine());
                                if (choice == 1)
                                {
                                Console.WriteLine("Продолжаю...");
                                Console.ReadKey();
                            }
                                if (choice == 2)
                                {
                                    i = 6;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Вы ввели что то не то.");
                                Console.WriteLine("Чтобы повторить введите 1, для выхода введите 2");

                                int choice = Convert.ToInt32(Console.ReadLine());
                                if (choice == 1)
                                {
                                Console.WriteLine("Продолжаю...");
                                Console.ReadKey();
                            }
                                if (choice == 2)
                                {
                                    i = 6;
                                }
                            }
                        }
                        else
                        {
                            if (day.Contains("Среда"))
                            {
                                Console.WriteLine("Введите количество задач:");

                                bool result = Int32.TryParse(Console.ReadLine(), out tasks[i]);
                                if (result)
                                {
                                    w1[i] = Week.Wednesday;

                                    Console.WriteLine("Вы добавили {0} задач для среды", tasks[i]);

                                    Console.WriteLine("Чтобы повторить введите 1, для выхода введите 2");

                                    int choice = Convert.ToInt32(Console.ReadLine());
                                    if (choice == 1)
                                    {
                                    Console.WriteLine("Продолжаю...");
                                    Console.ReadKey();
                                }
                                    if (choice == 2)
                                    {
                                        i = 6;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Вы ввели что то не то.");
                                    Console.WriteLine("Чтобы повторить введите 1, для выхода введите 2");

                                    int choice = Convert.ToInt32(Console.ReadLine());
                                    if (choice == 1)
                                    {
                                    Console.WriteLine("Продолжаю...");
                                    Console.ReadKey();
                                }
                                    if (choice == 2)
                                    {
                                        i = 6;
                                    }
                                }
                            }
                            else
                            {
                                if (day.Contains("Четверг"))
                                {
                                    Console.WriteLine("Введите количество задач:");

                                    bool result = Int32.TryParse(Console.ReadLine(), out tasks[i]);
                                    if (result)
                                    {
                                        w1[i] = Week.Thursday;

                                        Console.WriteLine("Вы добавили {0} задач для четверга", tasks[i]);

                                        Console.WriteLine("Чтобы повторить введите 1, для выхода введите 2");

                                        int choice = Convert.ToInt32(Console.ReadLine());
                                        if (choice == 1)
                                        {
                                        Console.WriteLine("Продолжаю...");
                                        Console.ReadKey();
                                    }
                                        if (choice == 2)
                                        {
                                            i = 6;
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Вы ввели что то не то.");
                                        Console.WriteLine("Чтобы повторить введите 1, для выхода введите 2");

                                        int choice = Convert.ToInt32(Console.ReadLine());
                                        if (choice == 1)
                                        {
                                        Console.WriteLine("Продолжаю...");
                                        Console.ReadKey();
                                    }
                                        if (choice == 2)
                                        {
                                            i = 6;
                                        }
                                    }
                                }
                                else
                                {
                                    if (day.Contains("Пятница"))
                                    {
                                        Console.WriteLine("Введите количество задач:");

                                        bool result = Int32.TryParse(Console.ReadLine(), out tasks[i]);
                                        if (result)
                                        {
                                            w1[i] = Week.Friday;

                                            Console.WriteLine("Вы добавили {0} задач для пятницы", tasks[i]);

                                            Console.WriteLine("Чтобы повторить введите 1, для выхода введите 2");

                                            int choice = Convert.ToInt32(Console.ReadLine());
                                            if (choice == 1)
                                            {
                                            Console.WriteLine("Продолжаю...");
                                            Console.ReadKey();
                                        }
                                            if (choice == 2)
                                            {
                                                i = 6;
                                            }
                                        }
                                        else
                                        {
                                            Console.WriteLine("Вы ввели что то не то.");
                                            Console.WriteLine("Чтобы повторить введите 1, для выхода введите 2");

                                            int choice = Convert.ToInt32(Console.ReadLine());
                                            if (choice == 1)
                                            {
                                            Console.WriteLine("Продолжаю...");
                                            Console.ReadKey();
                                        }
                                            if (choice == 2)
                                            {
                                                i = 6;
                                            }
                                        }
                                    }
                                    else
                                    {
                                        if (day.Contains("Суббота"))
                                        {
                                            Console.WriteLine("Введите количество задач:");

                                            bool result = Int32.TryParse(Console.ReadLine(), out tasks[i]);
                                            if (result)
                                            {
                                                w1[i] = Week.Saturday;

                                                Console.WriteLine("Вы добавили {0} задач для субботы", tasks[i]);

                                                Console.WriteLine("Чтобы повторить введите 1, для выхода введите 2");

                                                int choice = Convert.ToInt32(Console.ReadLine());
                                                if (choice == 1)
                                                {
                                                Console.WriteLine("Продолжаю...");
                                                Console.ReadKey();
                                            }
                                                if (choice == 2)
                                                {
                                                    i = 6;
                                                }
                                            }
                                            else
                                            {
                                                Console.WriteLine("Вы ввели что то не то.");
                                                Console.WriteLine("Чтобы повторить введите 1, для выхода введите 2");

                                                int choice = Convert.ToInt32(Console.ReadLine());
                                                if (choice == 1)
                                                {
                                                Console.WriteLine("Продолжаю...");
                                                Console.ReadKey();
                                            }
                                                if (choice == 2)
                                                {
                                                    i = 6;
                                                }
                                            }
                                        }
                                        else
                                        {
                                            if (day.Contains("Воскресенье"))
                                            {
                                                Console.WriteLine("Введите количество задач:");

                                                bool result = Int32.TryParse(Console.ReadLine(), out tasks[i]);
                                                if (result)
                                                {
                                                    w1[i] = Week.Sunday;

                                                    Console.WriteLine("Вы добавили {0} задач для воскресенья", tasks[i]);

                                                    Console.WriteLine("Чтобы повторить введите 1, для выхода введите 2");

                                                    int choice = Convert.ToInt32(Console.ReadLine());
                                                    if (choice == 1)
                                                    {
                                                    Console.WriteLine("Продолжаю...");
                                                    Console.ReadKey();
                                                }
                                                    if (choice == 2)
                                                    {
                                                        i = 6;
                                                    }
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Вы ввели что то не то.");
                                                    Console.WriteLine("Чтобы повторить введите 1, для выхода введите 2");

                                                    int choice = Convert.ToInt32(Console.ReadLine());
                                                    if (choice == 1)
                                                    {
                                                    Console.WriteLine("Продолжаю...");
                                                    Console.ReadKey();
                                                }
                                                    if (choice == 2)
                                                    {
                                                        i = 6;
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
                                                Console.WriteLine("Продолжаю...");
                                                Console.ReadKey();
                                            }
                                                if (choice == 2)
                                                {
                                                    i = 6;
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }

                //Использование битовой маски для проверки "зажженности" битов
                for (int i = 0; i < 6; i++)
                {
                    w = w1[i];
                    switch (w)
                    {
                        case Week.Monday:
                            Console.WriteLine("У вас есть {0} задач в понедельник", tasks[i]);
                            break;
                        case Week.Tuesday:
                            Console.WriteLine("У вас есть {0} задач во вторник", tasks[i]);
                            break;
                        case Week.Wednesday:
                            Console.WriteLine("У вас есть {0} задач в среду", tasks[i]);
                            break;
                        case Week.Thursday:
                            Console.WriteLine("У вас есть {0} задач в четверг", tasks[i]);
                            break;
                        case Week.Friday:
                            Console.WriteLine("У вас есть {0} задач в пятницу", tasks[i]);
                            break;
                        case Week.Saturday:
                            Console.WriteLine("У вас есть {0} задач в субботу", tasks[i]);
                            break;
                        case Week.Sunday:
                            Console.WriteLine("У вас есть {0} задач в воскресенье", tasks[i]);
                            break;
                        case Week.Empty:
                        default:
                            break;
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
