using System;

namespace _101115HomeWorkBigdan
{
    class Program
    {
        static void Main(string[] args)
        {
            int exit = 0;   //Объявление переменной, ответственной за продолжение работы или выход
            while (exit == 0)   //Пока exit == 0, программа будет продолжать выполнятся
            {
                Console.Clear();    //Очистка консоли  
                Console.WriteLine("Добрый день. \n Вы наслаждаетесь видом домашней работы, выполненной Бигданом Ростиславом.");
                Console.WriteLine("Пожалуйста выберите, чем вы хотите наслаждаться: \n Введите 1, если хотите перейти к выводу таблицы символов. \n Введите 2, если хотите перейти к работе с числами.");
                string choiсe = Console.ReadLine();     //Ввод символа, отвечающего за выбор выполняемого действия.
                if (choiсe == "1")      //Если введен символ "1", то начнется вывод таблицы символов Юникода
                {
                    Console.Clear();
                    int count = 0;  //Переменная, отвечающая за подсчет строк. Увеличивается с каждой итерацией
                    Console.WriteLine("Вы выбрали вывод таблицы символов. \n Пожалуйста введите количество символов, выводимых на экран:");
                    int colvo = Convert.ToInt32(Console.ReadLine());    //Переменная, отвечающая за количество выводимых символов.
                    Console.WriteLine("Введите количество строк в колонке:");
                    int colvos = Convert.ToInt32(Console.ReadLine());   //Переменная, отвечающая за количество строк в столбце.
                    for (char i = '\0'; i < colvo; ++i)     //Цикл, в котором задаются рамки выводимых символов.
                    {
                        int x = i;  //Переменная, которая показывает текущий номер символа
                        Console.WriteLine("│ Номер:{0}/{1} - Символ:{2} │", x, colvo-1, i);     //Вывод символов
                        ++count;    //Увеличение переменной count на 1 с каждой итерацией. Необходимо для разделения на столбцы.
                        if (count == colvos)    //Оператор if, отвечающий за сравнение count с заданным количеством строк. Если эти значения равны происходит переход к следуещему столбцу.
                        {
                            count = 0;  //Обнуление перемменной, отвечающей за подсчет строк.
                            Console.WriteLine("├────────────────────────┤");
                            Console.WriteLine();
                            Console.WriteLine("├────────────────────────┤");
                        }
                    }
                    Console.WriteLine("Чтобы повторить введите Y, для выхода введите Exit");    //Выбор действия после завершения операций.
                    string choiсe2 = Console.ReadLine();
                    if (choiсe2 == "Y")     //Если введено "Y", то работа продолжается
                    {
                        exit = 0;   //Переменная exit остается равной 0
                    }
                    if (choiсe2 == "Exit")      //Если "Exit", то работа прекращается
                    {
                        exit = 1;   //Переменная exit становится равной 1 и работа прекращается т.к. while действует только пока exit == 0
                    }
                }
                else
                {
                    if (choiсe == "2")      //Если введен символ "2", то начнется сравнение четырех вводимых символов
                    {
                        Console.Clear();
                        Console.WriteLine("Вы выбрали работу с числами.");
                        Console.WriteLine("Введите первое число:");
                        int num1 = Convert.ToInt32(Console.ReadLine());     //Ввод первого числа
                        Console.WriteLine("Введите второе число:");
                        int num2 = Convert.ToInt32(Console.ReadLine());     //Ввод второго числа
                        Console.WriteLine("Введите третье число:");
                        int num3 = Convert.ToInt32(Console.ReadLine());     //Ввод третьего числа
                        Console.WriteLine("Введите четвертое число:");
                        int num4 = Convert.ToInt32(Console.ReadLine());     //Ввод четвертого числа

                        int max = 0;
                        int min = 0;

                        if (num1 >= num2 && num1 >= num3 && num1 >= num4)                              //Сравнение чисел для выявления наибольшего и наименьшего.
                        {                                                                           //Эта операция производится 4 раза для наибольшего и 4 раза для наименьшего чисел.
                            max = num1;
                        }
                        else
                        {
                            if (num2 >= num1 && num2 >= num3 && num2 >= num4)
                            {
                                max = num2;
                            }
                            else
                            {
                                if (num3 >= num1 && num3 >= num2 && num1 >= num4)
                                {
                                    max = num3;
                                }
                                else
                                {
                                    if (num4 >= num1 && num4 >= num2 && num4 >= num3)
                                    {
                                        max = num4;
                                    }
                                }
                            }
                        }
                        if (num1 <= num2 && num1 <= num3 && num1 <= num4)
                        {
                            min = num1;
                        }
                        else
                        {
                            if (num2 <= num1 && num2 <= num3 && num2 <= num4)
                            {
                                min = num2;
                            }
                            else
                            {
                                if (num3 <= num1 && num3 <= num2 && num1 <= num4)
                                {
                                    min = num3;
                                }
                                else
                                {
                                    if (num4 <= num1 && num4 <= num2 && num4 <= num3)
                                    {
                                        min = num4;
                                    }
                                }
                            }
                        }

                        Console.WriteLine("Наибольшим оказалось число: {0}", max);
                        Console.WriteLine("Наименьшим оказалось число: {0}", min);

                        Console.WriteLine("Чтобы повторить введите Y, для выхода введите Exit");
                        string choiсe2 = Console.ReadLine();
                        if (choiсe2 == "Y")
                        {
                            exit = 0;
                        }
                        if (choiсe2 == "Exit")
                        {
                            exit = 1;
                        }
                    }
                    else    //В случае если был введен не тот символ будет предложено повторить ввод, или выйти и программы.
                    {
                        Console.WriteLine("Вы ввели что-то не то. \n Чтобы повторить введите Y, для выхода введите Exit");
                        string choise2 = Console.ReadLine();
                        if (choise2 == "Y")
                        {
                            exit = 0;
                        }
                        if (choise2 == "Exit")
                        {
                            exit = 1;
                        }
                    }
                }
            }
        }
    }
}
