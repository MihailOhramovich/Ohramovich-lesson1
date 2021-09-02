using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5_b
{
    class Program
    {
        static void Pause()
        {
            Console.ReadKey();
        }


        static void Main(string[] args)

        // а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
        // б) Сделать задание, только вывод организовать в центре экрана.




        {
            #region Задание а и б Охрамович
            string centreText = "Охрамович Михаил Из Краснодара ";
            int centerX = (Console.WindowWidth / 2) - (centreText.Length / 2);
            int centerY = (Console.WindowHeight / 2) - 1;
            Console.SetCursorPosition(centerX, centerY);
            Console.Write(centreText);
            Pause();
            #endregion
        }
    }
}
