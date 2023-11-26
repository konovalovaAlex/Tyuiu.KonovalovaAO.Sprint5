using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KonovalovaAO.Sprint5.Task5.V17.Lib;
namespace Tyuiu.KonovalovaAO.Sprint5.Task5.V17
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
            Console.WriteLine("* Вариант #17                                                            *");
            Console.WriteLine("* Выполнила: Коновалова Александра Олеговна | СМАРТб-23-1                *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                               *");
            Console.WriteLine("* Дан файл С: DataSprint5 InPutDataFileTask5V17.txt (файл взять из       *");
            Console.WriteLine("* архива согласно вашему варианту. Создать папку в ручную С:             *");
            Console.WriteLine("* DataSprint5 и скопировать в неё файл) в котором есть набор значений.   *");
            Console.WriteLine("* Найти сумму всех простых целых чисел в файле. Полученный результат     *");
            Console.WriteLine("* вывести на консоль. У вещественных значений округлить до трёх          *");
            Console.WriteLine("* знаков после запятой.                                                  *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");
            string path = @"C:\DataSprint5\InPutDataFileTask5V17.txt";
            Console.WriteLine("Данные находятся в файле: " + path);
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("**************************************************************************");
            double res = ds.LoadFromDataFile(path);
            Console.WriteLine("Сумма всех простых целых чисел равна = " + res);
            Console.ReadKey();

        }
    }
}
