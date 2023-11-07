using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.DubrovinSN.Sprint4.Task6.V19.Lib;

namespace Tyuiu.DubrovinSN.Sprint4.Task6.V19
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #4 | Выполнил: Дубровин С.Н | ИИПб-23-3";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Обработка структурных типов                                       *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #19                                                             *");
            Console.WriteLine("* Выполнил: Дубровин Степан Николаевич | ИИПб-23-3                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан строковый массив данных [Chrome, Firefox, Safari, Opera, Edge,      *");
            Console.WriteLine("* Internet Explorer, Brav] используя класс Array подсчитайте количество   *");
            Console.WriteLine("* элементов, длина которых больше 5.                                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string[] mas = { "Chrome", "Firefox", "Safari", "Opera", "Edge", "Internet Explorer", "Brave" };
            string array = string.Join(",", mas);
            Console.WriteLine("[" + array + "]");
           
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Результат                                                               *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Количесвто элементов,длина которых больше 5 равна: " + ds.Calculate(mas));
            Console.ReadKey();
        }
    }
}
