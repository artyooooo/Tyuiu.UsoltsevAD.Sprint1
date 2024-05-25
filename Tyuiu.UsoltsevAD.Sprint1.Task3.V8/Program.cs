﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.UsoltsevAD.Sprint1.Task3.V8.Lib;
namespace Tyuiu.UsoltsevAD.Sprint1.Task3.V8
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();


            Console.Title = "Спринт #1 | Выполнил: Усольцев А.Д. | АСОиУб-23-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Операторы составного присваивания                                 *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #8                                                              *");
            Console.WriteLine("* Выполнила: Усольцев Артём Денисович | АСОиУб-23-2                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
            Console.WriteLine("* выполняет указанные расчет и печатает результат на экране.              *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            double startAmount;
            double percent;
            double timeDays;
            Console.WriteLine("Введите величину вклада (руб): ");
            startAmount = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите процентную ставку (годовых): ");
            percent = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите срок вклада (дней): ");
            timeDays = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Доход = " + ds.IncomeAmount(timeDays, percent, startAmount));

            Console.ReadKey();
        }
    }
}
