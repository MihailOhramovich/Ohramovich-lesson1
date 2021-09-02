using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ohramovich
{
    class Program
    {
        { static void Pause()
        {
            Console.ReadKey();
        }

        
        static void Main(string[] args)
        {
            #region Задача 3 Охрамович
            //а) Написать программу, которая подсчитывает расстояние между точками с координатами x1, y1 и x2,y2 по формуле r=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2). Вывести результат, используя спецификатор формата .2f (с двумя знаками после запятой);
            
            Console.WriteLine("Координаты первой точки: х= \n");
            var x1 = Console.ReadLine();
            Console.WriteLine("Координаты первой точки: y= \n");
            var y1 = Console.ReadLine();
            Console.WriteLine("Координаты второй точки: х= \n");
            var x2 = Console.ReadLine();
            Console.WriteLine("Координаты второй точки: y= \n");
            var y2 = Console.ReadLine();


            var r = Math.Sqrt(Math.Pow(Convert.ToDouble(x2) - Convert.ToDouble(x1), 2) + Math.Pow(Convert.ToDouble(y2) - Convert.ToDouble(y1), 2));
            Console.WriteLine("Расстояние между точками = " + "{0:F2}", r);
            Pause();




            
         




            #endregion
        }
    }
}
