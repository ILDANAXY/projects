using Microsoft.VisualBasic;
using System;

namespace Приветствие_и_ваш_возраст
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Здравствуйте! Напишите ваше имя:");
            String name = Console.ReadLine();
            Console.WriteLine("Введите сегоднешний или любой другой НОМЕР ДНЯ, по которому программа определит ваш возраст:");
            String date_new = Console.ReadLine();
            int date_int_new = Convert.ToInt32(date_new);
            Console.WriteLine("Введите сегоднешний или любой другой НОМЕР МЕСЯЦА, по которому программа определит ваш возраст?");
            String month_new = Console.ReadLine();
            int month_int_new = Convert.ToInt32(month_new);
            if (month_int_new == 2 && date_int_new > 29)
            {
                Console.WriteLine("Некорректно введены данные. Запустите програграмму заново!");
            }
            else if ((date_int_new > 31 | date_int_new < 1) | (month_int_new > 12 | month_int_new < 1))
            {
                Console.WriteLine("Некорректно введены данные. Запустите програграмму заново!");
            }
            else
            {
                Console.WriteLine("Введите сегоднешний или любой другой ГОД, по которому программа определит ваш возраст:");
                String year_new = Console.ReadLine();
                int year_int_new = Convert.ToInt32(year_new);

                Console.WriteLine("Введите номер дня вашего рождения:");
            String date = Console.ReadLine();
            int date_int = Convert.ToInt32(date);
            Console.WriteLine("Какой номер месяца вашего рождения?");
            String month = Console.ReadLine();
            int month_int = Convert.ToInt32(month);
                if (month_int == 2 && date_int > 29)
                {
                    Console.WriteLine("Некорректно введены данные. Запустите програграмму заново!");
                }
                else if ((date_int >= 31 | date_int <= 1) | (month_int > 12 | month_int < 1))
                {
                    Console.WriteLine("Некорректно введены данные. Запустите програграмму заново!");
                }
                else
                {
                    Console.WriteLine("Какой год вашего рождения?");
                    String year = Console.ReadLine();
                    int year_int = Convert.ToInt32(year);


                    int age;
                    //Проверка на високосный год: (1) делится на 4 без остатка, не делится на 100 без остатка; (2) если делится на 100, то должен поделиться на 400.
                    if (year_int % 4 == 0)
                    {
                        if ((year_int % 100 != 0) && (year_int % 100 == 0 && year_int % 400 == 0))
                        {
                            if ((month_int == 1 || month_int == 3 || month_int == 5 || month_int == 7 || month_int == 8 || month_int == 10 || month_int == 12) && (date_int >= 1 && date_int <= 31))
                            {
                                if (year_int_new > year_int)
                                {
                                    if (month_int_new > month_int)
                                    {
                                        age = year_int_new - year_int;
                                        Console.WriteLine("Привет, " + name + ". Ваш возраст равен " + age + " лет. Приятно познакомиться.");
                                    }
                                    else if (month_int_new == month_int)
                                    {
                                        if (date_int_new >= date_int)
                                        {
                                            age = year_int_new - year_int;
                                            Console.WriteLine("Привет, " + name + ". Ваш возраст равен " + age + " лет. Приятно познакомиться.");
                                        }
                                        else
                                        {
                                            age = year_int_new - year_int - 1;
                                            Console.WriteLine("Привет, " + name + ". Ваш возраст равен " + age + " лет. Приятно познакомиться.");
                                        }
                                    }
                                    else
                                    {
                                        age = year_int_new - year_int - 1;
                                        Console.WriteLine("Привет, " + name + ". Ваш возраст равен " + age + " лет. Приятно познакомиться.");
                                    }
                                }
                            }
                            else if ((month_int == 4 || month_int == 6 || month_int == 9 || month_int == 11) && (date_int >= 1 && date_int <= 30))
                            {
                                if (year_int_new > year_int)
                                {
                                    if (month_int_new > month_int)
                                    {
                                        age = year_int_new - year_int;
                                        Console.WriteLine("Привет, " + name + ". Ваш возраст равен " + age + " лет. Приятно познакомиться.");
                                    }
                                    else if (month_int_new == month_int)
                                    {
                                        if (date_int_new >= date_int)
                                        {
                                            age = year_int_new - year_int;
                                            Console.WriteLine("Привет, " + name + ". Ваш возраст равен " + age + " лет. Приятно познакомиться.");
                                        }
                                        else
                                        {
                                            age = year_int_new - year_int - 1;
                                            Console.WriteLine("Привет, " + name + ". Ваш возраст равен " + age + " лет. Приятно познакомиться.");
                                        }
                                    }
                                    else
                                    {
                                        age = year_int_new - year_int - 1;
                                        Console.WriteLine("Привет, " + name + ". Ваш возраст равен " + age + " лет. Приятно познакомиться.");
                                    }
                                }
                            }
                            else if (month_int == 2 && date_int >= 1 && date_int <= 29)
                            {
                                if (year_int_new > year_int)
                                {
                                    if (month_int_new > month_int)
                                    {
                                        age = year_int_new - year_int;
                                        Console.WriteLine("Привет, " + name + ". Ваш возраст равен " + age + " лет. Приятно познакомиться.");
                                    }
                                    else if (month_int_new == month_int)
                                    {
                                        if (date_int_new >= date_int)
                                        {
                                            age = year_int_new - year_int;
                                            Console.WriteLine("Привет, " + name + ". Ваш возраст равен " + age + " лет. Приятно познакомиться.");
                                        }
                                        else
                                        {
                                            age = year_int_new - year_int - 1;
                                            Console.WriteLine("Привет, " + name + ". Ваш возраст равен " + age + " лет. Приятно познакомиться.");
                                        }
                                    }
                                    else
                                    {
                                        age = year_int_new - year_int - 1;
                                        Console.WriteLine("Привет, " + name + ". Ваш возраст равен " + age + " лет. Приятно познакомиться.");
                                    }
                                }
                            }
                        }
                    }
                    //Обычный год
                    else
                    {
                        if ((month_int == 1 || month_int == 3 || month_int == 5 || month_int == 7 || month_int == 8 || month_int == 10 || month_int == 12) && (date_int >= 1 && date_int <= 31))
                        {
                            if (year_int_new > year_int)
                            {
                                if (month_int_new > month_int)
                                {
                                    age = year_int_new - year_int;
                                    Console.WriteLine("Привет, " + name + ". Ваш возраст равен " + age + " лет. Приятно познакомиться.");
                                }
                                else if (month_int_new == month_int)
                                {
                                    if (date_int_new >= date_int)
                                    {
                                        age = year_int_new - year_int;
                                        Console.WriteLine("Привет, " + name + ". Ваш возраст равен " + age + " лет. Приятно познакомиться.");
                                    }
                                    else
                                    {
                                        age = year_int_new - year_int - 1;
                                        Console.WriteLine("Привет, " + name + ". Ваш возраст равен " + age + " лет. Приятно познакомиться.");
                                    }
                                }
                                else
                                {
                                    age = year_int_new - year_int - 1;
                                    Console.WriteLine("Привет, " + name + ". Ваш возраст равен " + age + " лет. Приятно познакомиться.");
                                }
                            }
                        }
                        else if ((month_int == 4 || month_int == 6 || month_int == 9 || month_int == 11) && (date_int >= 1 && date_int <= 30))
                        {
                            if (year_int_new > year_int)
                            {
                                if (month_int_new > month_int)
                                {
                                    age = year_int_new - year_int;
                                    Console.WriteLine("Привет, " + name + ". Ваш возраст равен " + age + " лет. Приятно познакомиться.");
                                }
                                else if (month_int_new == month_int)
                                {
                                    if (date_int_new >= date_int)
                                    {
                                        age = year_int_new - year_int;
                                        Console.WriteLine("Привет, " + name + ". Ваш возраст равен " + age + " лет. Приятно познакомиться.");
                                    }
                                    else
                                    {
                                        age = year_int_new - year_int - 1;
                                        Console.WriteLine("Привет, " + name + ". Ваш возраст равен " + age + " лет. Приятно познакомиться.");
                                    }
                                }
                                else
                                {
                                    age = year_int_new - year_int - 1;
                                    Console.WriteLine("Привет, " + name + ". Ваш возраст равен " + age + " лет. Приятно познакомиться.");
                                }
                            }
                        }
                        else if (month_int == 2 && date_int >= 1 && date_int <= 28)
                        {
                            if (year_int_new > year_int)
                            {
                                if (month_int_new > month_int)
                                {
                                    age = year_int_new - year_int;
                                    Console.WriteLine("Привет, " + name + ". Ваш возраст равен " + age + " лет. Приятно познакомиться.");
                                }
                                else if (month_int_new == month_int)
                                {
                                    if (date_int_new >= date_int)
                                    {
                                        age = year_int_new - year_int;
                                        Console.WriteLine("Привет, " + name + ". Ваш возраст равен " + age + " лет. Приятно познакомиться.");
                                    }
                                    else
                                    {
                                        age = year_int_new - year_int - 1;
                                        Console.WriteLine("Привет, " + name + ". Ваш возраст равен " + age + " лет. Приятно познакомиться.");
                                    }
                                }
                                else
                                {
                                    age = year_int_new - year_int - 1;
                                    Console.WriteLine("Привет, " + name + ". Ваш возраст равен " + age + " лет. Приятно познакомиться.");
                                }
                            }
                        }
                    }
                }
            }
    }
}
}

