﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KonovalovaAO.Sprint5.Task3.V27.Lib;
namespace Tyuiu.KonovalovaAO.Sprint5.Task3.V27
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #5 | Выполнила: Коновалова А. О. | СМАРТб-23-1";
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* Спринт #5                                                              *");
            Console.WriteLine("* Тема: Обработка файлов                                                 *");
            Console.WriteLine("* Задание #3                                                             *");
            Console.WriteLine("* Вариант #27                                                            *");
            Console.WriteLine("* Выполнила: Коновалова Александра Олеговна | СМАРТб-23-1                *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                               *");
            Console.WriteLine("* Дано выражение вычислить его значение при x = 3, результат сохранить в *");
            Console.WriteLine("* в бинарный файл OutPutFileTask3.bin и вывести на консоль.              *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");

            int x = 3;
            Console.WriteLine("Значение X = " + x);

            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* Результат                                                              *");
            Console.WriteLine("**************************************************************************");
            string res = ds.SaveToFileTextData(x);
            Console.WriteLine("Файл: " + res);
            Console.WriteLine("Создан!");
            Console.ReadKey();

        }
    }
}
