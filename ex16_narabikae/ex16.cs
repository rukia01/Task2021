using System;

namespace ex16_narabikae
{
    class ex16
    {
        static void Main(string[] args)
        {
            int maxInteger = 10;
            int max = -100;
            int min = 100;
            double averageValue = 0;
            int[] integer = new int[maxInteger];
            for (var i = 0; i < integer.Length; i++)
            {
                Console.WriteLine($"{i + 1}番目の整数を入力してください(-100～100の間)");
                integer[i] = int.Parse(Console.ReadLine());
            }
            for (var i = 0; i < integer.Length; i++)
            {
                if (max <= integer[i])
                {
                    max = integer[i];
                }
                if (min >= integer[i])
                {
                    min = integer[i];
                }
                averageValue = averageValue + integer[i];
            }
            Console.WriteLine($"最大値{max}");
            Console.WriteLine($"最小値{min}");
            Console.WriteLine($"平均値{averageValue / maxInteger}");
        }
    }
}
