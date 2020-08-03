using Microsoft.VisualBasic;
using System;
using System.Runtime.Serialization;

namespace HW1
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] t = new double[5];
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Введите температуру текущего дня и нажмите Enter");
                t[i] = Convert.ToDouble(Console.ReadLine());
            }
            Console.WriteLine("\nТемпература в прямом порядке введения: " + t[0] + ";" + t[1] + ";" + t[2] + ";" + t[3] + ";" + t[4] + ";");
            Console.WriteLine("\nТемпература в обратном порядке введения: " + t[4] + ";" + t[3] + ";" + t[2] + ";" + t[1] + ";" + t[0] + ";");
            {
                double mid = (t[0] + t[1] + t[2] + t[3] + t[4]) / 5;
                Console.WriteLine("\nСреднее значение температуры: " + mid);
            }
            {
                if (t[0]>t[4])
                {
                    Console.WriteLine("\nТемпература падает.");
                }
                else if (t[4] > t[0])
                {
                    Console.WriteLine("\nТемпература растет.");
                }
                else
                {
                    Console.WriteLine("\nТемпература неоднозначна.");
                }
            }
            {
                double mid = (t[0] + t[1] + t[2] + t[3] + t[4]) / 5;
                Console.WriteLine("\nРекомендации: ");
                if (mid <= -20)
                {
                    Console.WriteLine("На улице очень холодно. Одевайтесь очень тепло. ");
                }
                else if (mid > -20 && mid <=-5)
                {
                    Console.WriteLine("На улице холодно. Надо быть осторожнее. Одевайтесь теплее. ");
                }
                else if (mid > -5 && mid <= 5)
                {
                    Console.WriteLine("На улице прохладно. Не время убирать теплые вещи. ");
                }
                else if (mid > 5 && mid < 20)
                {
                    Console.WriteLine("На улице все еще прохладно.Не обманывайтесь и одевайтесь тепло. ");
                }
                else
                {
                    Console.WriteLine("На улице жарко. Аккуратнее с солнцем. ");
                }
                Console.ReadKey();

            }
        }

    }
}
