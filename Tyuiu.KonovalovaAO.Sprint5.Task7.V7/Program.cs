using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KonovalovaAO.Sprint5.Task7.V7.Lib;
using System.IO;
namespace Tyuiu.KonovalovaAO.Sprint5.Task7.V7
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #5 | Выполнила: Коновалова А. О. | СМАРТб-23-1";
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* Спринт #5                                                              *");
            Console.WriteLine("* Тема:  Добавление к решению итоговых проектов по спринту               *");
            Console.WriteLine("* Задание #7                                                             *");
            Console.WriteLine("* Вариант #7                                                             *");
            Console.WriteLine("* Выполнила: Коновалова Александра Олеговна | СМАРТб-23-1                *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                               *");
            Console.WriteLine("* Создать папку в ручную и скопировать в неё файл в котором есть набор   *");
            Console.WriteLine("* символьных данных.Удалить все заглавные русские буквы из файла.        *");
            Console.WriteLine("* Полученный результат сохранить в файл OutPutDataFileTask7V7.txt.       *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");
            string path = @"C:\DataSprint5\InPutDataFileTask7V7.txt";
            string pathSaveFile = @"C:\DataSprint5\OutPutDataFileTask7V7.txt";

            Console.WriteLine("Файл: " + path);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Находятся в файле: ");
            pathSaveFile = ds.LoadDataAndSave(path);
            Console.WriteLine(pathSaveFile);

            Console.ReadKey();
        }
    }
}
