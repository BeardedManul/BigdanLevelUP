using System;

namespace _151123_Enums
{
    class Program
    {
        enum Direction : int
        {
            North,
            South,
            West,
            East
        }

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

        [Flags] // - указание компилятору использовать перечисление как набор флагов
        enum WeekFlag : int
        {
            Empty = 0x00,
            Monday = 0x01,
            Tuesday = 0x02,
            Wednesday = 0x04,
            Thursday = 0x08,
            Friday = 0x16,
            Saturday = 0x32,
            Sunday = 0x64
        }

        static void Main(string[] args)
        {
            int exit = 0;   //Пока равна 0 работает основной цикл
            string day;
            Direction d = 0;
            Week w = Week.Empty;
            WeekFlag wf = WeekFlag.Empty;
            Week[] w1 = new Week[7];
            WeekFlag[] wf1 = new WeekFlag[7];
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
                Console.WriteLine("Вы наслаждаетесь видом третьего домашнего задания,");
                Console.WriteLine("выполненного Ростиславом Бигданом!");
                Console.WriteLine("Введите 1, чтобы перейти к работе с расписанием, или 2, чтобы поучавствовать в приключении");

                int choice_main;
                bool res = Int32.TryParse(Console.ReadLine(), out choice_main);

                if (res)
                {
                    if (choice_main == 2)
                    {
                        string action1 = " увидел огромный раскидистый дуб. \nНа вид ему не меньше сотни лет.\nЯ подошел поближе и вдруг заметил маленькую девочку, играющую возле корней векового дуба.\nЯ попытался подойти ближе к девочке, но вдруг почувствовал как земля резко ушла из под ног.\nЯ потерял сознание";
                        string action2 = " сухая ветка с треском падает с дерева и ударяет мне по голове. Я теряю сознание.";
                        string action3 = " увидел реку, вода с ревом проносилась мимо меня. \nНа глаз глубина была не меньше 5-6 метров и никаких способов перебраться на другой берег я не видел. \nПохоже мне придется вернуться.";
                        string action4 = " почувствовал как что-то укусило меня за ногу. \nЯ успел увидеть переливы змеиной чешуи в траве прежде чем тьма забрала меня в свои обьятия. \nЯ потерял сознание.";
                        string action5 = " увидел старую часовню посреди леса. \nКаменные стены от времени пошли трещинами, а крыша почти полностью обвалилась. \nЯ зашел в часовню и подошел к покрытому пылью алтарю. \nВдруг я услышал колокольный звон. \nЕго звон все нарастал, он становился невыносимым. \nЯ теряю сознание, слыша этот невыносимый звон.";
                        string[] action_main = new String[] {action1, action2, action3, action4, action5 };


                        Console.Clear();
                        Console.WriteLine("Вы сделали правильный выбор! Да начнется приключение!");
                        Console.ReadKey();
                        Console.Clear();
                        Console.WriteLine("Я проснулся, стуча зубами.");
                        Console.WriteLine("Тело, порядком замерзшее от ноябрьского холода, слушалось с трудом,");
                        Console.WriteLine("и мне пришлось немало повозиться, прежде чем я смог привести себя в относительный порядок.");
                        Console.WriteLine("Поднявшись с земли, усыпанной опавшей листвой, я решил осмотреться...");
                        Console.ReadKey();
                        Console.WriteLine("\nЛес. Повсюду, куда ни посмотри, глухой, старый и неприветливый лес.");
                        Console.ReadKey();
                        Console.WriteLine("\nЯ не помнил как меня сюда занесло. Происходящее казалось скорее сном, чем чем-то происходящим в действительности.");
                        Console.WriteLine("Я помнил как еще вчера вечером сидел у себя дома, кот терся об мои ноги, а поленья задорно потрескивали в камине.");
                        Console.WriteLine("И вот я здесь.");
                        Console.ReadKey();
                        Console.WriteLine("\nЛадно, хватит! Сидеть сиднем в лесу, где повсюду куда ни глянь одни голые остовы деревьев, занятие не из приятных.");
                        Console.WriteLine("Я решил что стоит попытаться выбраться из леса, а там может найду местных, попрошу помочь доехать до дома.");
                        Console.WriteLine("Однако повернувшись на запад, я почувствовал как ком подступает к горлу и цепкие лапки страха сковывают сердце");
                        Console.ReadKey();

                        for (int j = 0; j < 6; j++)
                        {
                            Random action = new Random();       //Генератор псевдослучайных чисел
                            int x = action.Next(4);
                            

                            Console.Clear();
                            Console.WriteLine("Я стоию на поляне посреди леса.");
                            Console.WriteLine("\nКуда мне пойти?");
                            Console.WriteLine("Доступные мне направления: ");

                            foreach (string item in Enum.GetNames(typeof(Direction)))
                            {
                                Console.WriteLine("{0}", item);
                            }

                            string dir = Console.ReadLine();

                            if (dir == "North")
                            {
                                d = Direction.North;
                            }
                            else
                            {
                                if (dir == "South")
                                {
                                    d = Direction.South;
                                }
                                else
                                {
                                    if (dir == "West")
                                    {
                                        d = Direction.West;
                                    }
                                    else
                                    {
                                        if (dir == "East")
                                        {
                                            d = Direction.East;
                                        }
                                    }
                                }
                            }
                            if (d == Direction.South)
                            {
                                Console.WriteLine("Я долго шел, проламываясь через сухие ветви, и вдруг{0}", action_main[x]);
                                Console.ReadKey();
                            }
                            if (d == Direction.East)
                            {
                                Console.WriteLine("Я долго шел, проламываясь через сухие ветви, и вдруг{0}", action_main[x]);
                                Console.ReadKey();
                            }
                            if (d == Direction.North)
                            {
                                Console.WriteLine("Я долго шел, проламываясь через сухие ветви, и вдруг{0}", action_main[x]);
                                Console.ReadKey();
                            }

                            if (d == Direction.West)
                            {
                                Console.WriteLine("\nНесмотря на плохие предчувствия, я пошел на запад и вышел к огромному входу в пещеру.");
                                Console.WriteLine("Оттуда веяло холодом и гнилью.");
                                Console.WriteLine("Хочу ли я зайти в пещеру?");

                                string cave = Console.ReadLine();

                                if (cave == "Да")
                                {
                                    Console.WriteLine("\nЯ решил перебороть свой страх и зайти в пещеру");
                                    Console.ReadLine();
                                    Console.WriteLine("\nВнутри было холодно, сыро, а запах гнили стал еще сильнее.");
                                    Console.WriteLine("Однако в дальнем конце пещеры я увидел ядва заметный луч света, пробивающийся через дыру в стене.");
                                    Console.WriteLine("При ближайшем рассмотрении трещина оказалась достаточно широкой, чтобы взрослый человек мог ползком пролезть через нее.");
                                    Console.WriteLine("Я решил попробовать пролезть через дыру");
                                    Console.ReadKey();
                                    Console.WriteLine("\nЛаз был недлинным, но довольно узким. Однако уже спустя 5 минут я оказался по ту сторону стены.");
                                    Console.WriteLine("На сей раз я оказался в небольшой пещере, стены которой были испещрены странными рунами.");
                                    Console.WriteLine("На полу повсюду стояли зажженные свечи, а посреди пещеры стояла статуя какого-то божества.");
                                    Console.WriteLine("Подойдя ближе к статуе я заметил небольшой алтарь. На алтаре лежал клочок бумаги.");
                                    Console.WriteLine("На листке бумаги кривым почерком было нацарапано всего одно слово:");
                                    Console.ReadKey();
                                    Console.Clear();
                                    Console.WriteLine("Обернись");
                                    Console.ReadKey();
                                    Console.Clear();
                                    Console.WriteLine("Я успел сделать лишь пол оборота, как жгучая боль пронзила грудь.");
                                    Console.WriteLine("Ритуальный кинжал вошел под ребра и пронзил сердце. В глазах потемнело...");
                                    Console.WriteLine("И, пока моя кровь стекала на алтарь, я услышал: ");
                                    Console.WriteLine("О великий Ктулху, прими эту жертву!");
                                    Console.WriteLine("Пх’нглуи мглв’нафх Ктулху Р’льех вгах’нагл фхтагн");
                                    Console.WriteLine("Слишком долго ты спал в Р’льехе! Пробудись!");
                                    Console.WriteLine("Пробудись, и пусть род людской познает, что такое истинные страдания!");
                                    Console.ReadKey();
                                    Console.Clear();
                                    Console.WriteLine("А потом была лишь тьма...");
                                    Console.ReadKey();
                                    Console.Clear();
                                    Console.WriteLine("Так закончилась моя история. Если хотите узнать другую концовку, начните мое приключение заново.");
                                    Console.ReadKey();
                                    return;
                                }
                                else
                                {
                                    Console.WriteLine("Плохие предчувствия взяли верх, я решил вернуться назад и выбрать другой путь.");
                                }
                            }
                        }
                        Console.Clear();
                        Console.WriteLine("Я устал бродить по лесу кругами.");
                        Console.WriteLine("Я отбросил всякий здравый смысл и просто понесся сломя голову не разбирая дороги.");
                        Console.WriteLine("Я бежал и бежал, пока наконец не увидел как деревья стали редеть. \nВот уже стала видна опушка.");
                        Console.WriteLine("Я выбрался...");
                        Console.ReadKey();
                        Console.Clear();
                        Console.WriteLine("Так закончилась моя история. Если хотите узнать другую концовку, начните мое приключение заново.");
                        Console.ReadKey();

                    }
                    if (choice_main == 1)
                    {
                        for (int i = 0; i < 7; i++)
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
                                    wf1[i] = WeekFlag.Monday;

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
                                        i = 7;
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
                                        i = 7;
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
                                        wf1[i] = WeekFlag.Tuesday;

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
                                            i = 7;
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
                                            i = 7;
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
                                            wf1[i] = WeekFlag.Wednesday;

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
                                                i = 7;
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
                                                i = 7;
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
                                                wf1[i] = WeekFlag.Thursday;

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
                                                    i = 7;
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
                                                    i = 7;
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
                                                    wf1[i] = WeekFlag.Friday;

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
                                                        i = 7;
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
                                                        i = 7;
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
                                                        wf1[i] = WeekFlag.Saturday;

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
                                                            i = 7;
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
                                                            i = 7;
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
                                                            wf1[i] = WeekFlag.Sunday;

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
                                                                i = 7;
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
                                                                i = 7;
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
                                                            i = 7;
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
                        for (int i = 0; i < 7; i++)
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

                        Console.WriteLine();

                        for (int i = 0; i < 7; i++)
                        {
                            wf = wf1[i];

                            if ((wf.HasFlag(WeekFlag.Monday)))
                            {
                                Console.WriteLine("У вас есть {0} задач в понедельник", tasks[i]);
                            }
                            else
                            {
                                if ((wf.HasFlag(WeekFlag.Tuesday)))
                                {
                                    Console.WriteLine("У вас есть {0} задач во вторник", tasks[i]);
                                }
                                else
                                {
                                    if ((wf.HasFlag(WeekFlag.Wednesday)))
                                    {
                                        Console.WriteLine("У вас есть {0} задач в среду", tasks[i]);
                                    }
                                    else
                                    {
                                        if ((wf.HasFlag(WeekFlag.Thursday)))
                                        {
                                            Console.WriteLine("У вас есть {0} задач в четверг", tasks[i]);
                                        }
                                        else
                                        {
                                            if ((wf.HasFlag(WeekFlag.Friday)))
                                            {
                                                Console.WriteLine("У вас есть {0} задач в пятницу", tasks[i]);
                                            }
                                            else
                                            {
                                                if ((wf.HasFlag(WeekFlag.Saturday)))
                                                {
                                                    Console.WriteLine("У вас есть {0} задач в субботу", tasks[i]);
                                                }
                                                else
                                                {
                                                    if ((wf.HasFlag(WeekFlag.Sunday)))
                                                    {
                                                        Console.WriteLine("У вас есть {0} задач в воскресенье", tasks[i]);
                                                    }
                                                    else
                                                    {
                                                        i = 7;
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
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
                else
                {
                    Console.WriteLine("Вы ввели что то не то");
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
}
