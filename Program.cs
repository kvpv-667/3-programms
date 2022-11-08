using System;
using System.Reflection.Metadata;

internal class Program
{
    static void Main(string[] args)
    {
        int q = 0;
        while (q != 4)
        {
            Console.WriteLine("Выбери операцию: \n1 - Угадай число \n2 - Таблица умножения \n3 - Вывод делителя \n4 - Финиш програмы");
            q = int.Parse(Console.ReadLine());

            if (q == 1)
            {
                d();
            }
            if (q == 2)
            {
                h();
            }
            if (q == 3)
            {
                u();
            }
        }
    }
    static void d()
    {
        Console.Title = "Угадай число";
        Random rand = new Random();
        int secret = rand.Next(100) + 1;
        Console.WriteLine("Я загадал число от 1 до 100");
        int s;
        do
        {
            s = int.Parse(Console.ReadLine());
            if (s == secret)
            {
                Console.WriteLine("Ты Угадал");
            }
            else
            {
                if (s < secret)
                {
                    Console.WriteLine("Число  больше");
                }
                else
                {
                    Console.WriteLine("Число меньше");
                }
            }
        }
        while (s != secret);
    }

    static void h()
    {
        string[,] dfd = new string[11, 11] { { "", "", "", "", "", "", "", "", "", "", "" }, { "", "", "", "", "", "", "", "", "", "", "" }, { "", "", "", "", "", "", "", "", "", "", "" }, { "", "", "", "", "", "", "", "", "", "", "" }, { "", "", "", "", "", "", "", "", "", "", "" }, { "", "", "", "", "", "", "", "", "", "", "" }, { "", "", "", "", "", "", "", "", "", "", "" }, { "", "", "", "", "", "", "", "", "", "", "" }, { "", "", "", "", "", "", "", "", "", "", "" }, { "", "", "", "", "", "", "", "", "", "", "" }, { "", "", "", "", "", "", "", "", "", "", "" }, };

        for (int m = 1; m < dfd.GetLength(0); m++)
        {
            for (int n = 1; n < dfd.GetLength(1); n++)
            {
                Console.Write(dfd[m, n] + m + "*" + n + "=" + m * n + "\t\t");
            }
            Console.WriteLine();
        }
    }
    static void u()
    {
        Console.Write("Введите число ");
        int num = int.Parse(Console.ReadLine());
        for (int i = 1; i <= num; i++)
            if (num % i == 0)
                Console.WriteLine("Число {0} делится без остатка на {1}", num, i);
    }
}
