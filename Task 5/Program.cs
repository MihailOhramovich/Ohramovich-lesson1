using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{
    class Program
    {

        static void Pause()
        {
            Console.ReadKey();
        }

        #region Задача 4 Охрамович
        // Написать программу обмена значениями двух переменных типа int без использования вспомогательных методов
        static void Main(string[] args)
        {
            int num1 = 2;
            int num2 = 1;
            int num3 = 0;
            Console.WriteLine(" " + num1 + " " + num2);


            num3 = num1;
            num1 = num2;
            num2 = num3;
            Console.WriteLine(" " + num1 + " " + num2);
            Pause();

            #endregion
        }
    }
}
