using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace HW2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введите количество слов в словаре: ");
            int m = Convert.ToInt32(Console.ReadLine());
            var d = new Dictionary<string, string>();
            for (int i = 0; i < m; i++)
            {
                Console.WriteLine("Введите слово");
                string slovo = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Введите значение");
                string znachenie = Convert.ToString(Console.ReadLine());
                d.Add(slovo, znachenie);
            }
            Console.WriteLine("В созданном словаре " + m + " слов(а) и они имеют следующие начения: /n.");
            foreach (KeyValuePair<string, string> keyValue in d)
            {
                Console.WriteLine(keyValue.Key + " имеет значение " + keyValue.Value);
            }
        }
    }
}
