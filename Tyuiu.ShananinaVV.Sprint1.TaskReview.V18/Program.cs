using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.ShananinaVV.Sprint1.TaskReview.V18.Lib;

namespace Tyuiu.ShananinaVV.Sprint1.TaskReview.V18
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнила: Шананина В. В. | ИСТНб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: SprintReview                                                      *");
            Console.WriteLine("* Вариант #18                                                             *");
            Console.WriteLine("* Выполнила: Шананина Валерия Викторовна | ИСТНб-23-1                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая вычисляет математическое выражение          *");
            Console.WriteLine("* по исходным значениям данных, вводимых пользователем.                   *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("                  2                                                        ");
            Console.WriteLine("           1 + sin  (x + y)       ");
            Console.WriteLine(" z =  ---------------------------  + x");
            Console.WriteLine("           |          2x       |  ");
            Console.WriteLine("     2 +   | x -   ----------- |  ");
            Console.WriteLine("           |             2  2  |  ");
            Console.WriteLine("           |        1 + x  y   |   ");

            double x;

            Console.WriteLine("Введите значение X:");
            x = Convert.ToDouble(Console.ReadLine());

            double y;

            Console.WriteLine("Введите значение Y:");
            y = Convert.ToDouble(Console.ReadLine());



            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");


            Console.WriteLine(ds.Calculate(x, y));
           Console.ReadKey();
        }
    }
}
