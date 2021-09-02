using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Задача 1 Охрамович
            //Написать программу «Анкета». Последовательно задаются вопросы (имя, фамилия, возраст, рост, вес). В результате вся информация выводится в одну строчку:
            {
                Console.WriteLine("Заполните анкету!Введите имя!\n");
                var name = Console.ReadLine();
                Console.WriteLine("\nВведите фамилию\n");
                var surname = Console.ReadLine();
                Console.WriteLine("\nВведите Возраст\n");
                var age = Console.ReadLine();
                Console.WriteLine("\nВведите рост в сантиметрах\n");
                var Height = Console.ReadLine();
                Console.WriteLine("\nВведите ваш вес\n");
                string weight = Console.ReadLine();
                Console.WriteLine($"Ваша анкета готов! Имя: { name} Фамилия: { surname} Возраст: { age} Рост: { Height} Вес: {weight}");
                Console.ReadLine();

                //Console.WriteLine($"Ваша анкета готов!\n \nИмя: { name} \nФамилия: { surname} \nВозраст: { age} \nРост: { Height} \nВес: {weight}");
                //Красиво выводит все значения на разные строки.


                #endregion



                #region Задача 2 Охрамович
                //2. Ввести вес и рост человека. Рассчитать и вывести индекс массы тела (ИМТ) по формуле I=m/(h*h); где m — масса тела в килограммах, h — рост в метрах.
                var Height2 = Convert.ToDouble(Height) / 100;
                double i = Convert.ToDouble(weight) / (Height2 * Height2);
                Console.WriteLine($"Сейчас мы рассчитаем ваш индекс массы тела\n При росте: {Height}\n  Весе: {weight} \nИМТ = {i}");
                Console.ReadLine();
                #endregion

            }
        }
}
