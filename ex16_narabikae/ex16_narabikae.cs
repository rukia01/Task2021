using System;

namespace ex16_narabikae
{
    class ex16_narabikae
    {
        static void Main(string[] args)
        {
            int maxInteger = 10;
            int maxId = 0;
            int vessel = 0;
            Random rand = new Random();
            int[] integer = new int[maxInteger];
            for (var i = 0; i < integer.Length; i++)
            {
                integer[i] = rand.Next(-100, 100);
                Console.WriteLine($"{i + 1}番目の整数:{integer[i]}");
            }

            for (var fixId = 0; fixId < integer.Length - 1; fixId++)
            {
                maxId = fixId;
                for(var i = maxId + 1;i < integer.Length;i++)
                {
                    if (integer[maxId] < integer[i])
                    {
                        maxId = i;

                    }
                   
                }
                vessel = integer[fixId];
                    integer[fixId] = integer[maxId];
                    integer[maxId] = vessel;
            }

            for (var i = 0; i < integer.Length; i++)
            {
                Console.WriteLine(integer[i]);
            }
        }
    }
}
