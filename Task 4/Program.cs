using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    class Program
    {
        static void Pause()
        {
            Console.ReadKey();
        }

        static void distance(double r, string x1, string x2, string y1, string y2)
        {
            r = Math.Sqrt(Math.Pow(Convert.ToDouble(x2) - Convert.ToDouble(x1), 2) + Math.Pow(Convert.ToDouble(y2) - Convert.ToDouble(y1), 2));
            Console.WriteLine("Расстояние между точками = " + "{0:F2}", r);
            Pause();
        }
        static void Main(string[] args)
        {
            #region Задача 3 * Охрамович

            //б) *Выполнить предыдущее задание, оформив вычисления расстояния между точками в виде метода.

            Console.WriteLine("Координаты первой точки: х= \n");
            var x1 = Console.ReadLine();
            Console.WriteLine("Координаты первой точки: y= \n");
            var y1 = Console.ReadLine();
            Console.WriteLine("Координаты второй точки: х= \n");
            var x2 = Console.ReadLine();
            Console.WriteLine("Координаты второй точки: y= \n");
            var y2 = Console.ReadLine();
            double r = 0;




            distance(r, x1, x2, y1, y2);
            Pause();
            // distance(); //  r - уже описана как метод в программе 
            #endregion

        }
    }
    
}
