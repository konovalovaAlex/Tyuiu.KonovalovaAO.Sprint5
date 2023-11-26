using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KonovalovaAO.Sprint5.Task6.V23.Lib;
namespace Tyuiu.KonovalovaAO.Sprint5.Task6.V23
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #5 | Выполнила: Коновалова А. О. | СМАРТб-23-1";
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* Спринт #5                                                              *");
            Console.WriteLine("*Тема: Чтение набора данных из текстового файла                          *");
            Console.WriteLine("* Задание #5                                                             *");
            Console.WriteLine("* Вариант #23                                                            *");
            Console.WriteLine("* Выполнила: Коновалова Александра Олеговна | СМАРТб-23-1                *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                               *");
            Console.WriteLine("* Дан файл С:\\DataSprint5\\InPutDataFileTask6V23.txt. в котором есть    *");
            Console.WriteLine("* набор символьных данных.Найти количество знаков тире в заданной строке.*");
            Console.WriteLine("*                                                                        *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");
            string path = @"C:\DataSprint5\InPutDataFileTask6V23.txt";
            Console.WriteLine("Данные находятся в файле: " + path);
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine(ds.LoadFromDataFile(path));
            Console.ReadKey();
        }
    }
}
