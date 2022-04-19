using System;

namespace ex13ex2
{
    class ex13ex2
    {
        const int Max = 10;
        const int MaxTime = 5;
        static void Main(string[] args)
        {
            Random rand = new Random();
            var answer = rand.Next(1, Max);
            var a = 0;
            var b = 0;
            for (int i = 0; i < MaxTime; i++)
            {
                Console.WriteLine($"いくつでしょうか。あと{MaxTime - i}回");
                var inputNum = int.Parse(Console.ReadLine());
                b = Math.Abs(inputNum - answer);
                if (i == 0)
                {
                    if (inputNum == answer)
                    {
                        Console.WriteLine("当たり");
                        Console.WriteLine($"{5000 / (i + 1)}点");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("はずれ");
                    }
                }

               else
                {

                    if (inputNum == answer)
                    {
                        Console.WriteLine("当たり");
                        Console.WriteLine($"{5000 / (i + 1)}点");
                        break;
                    }
                    else if (b < a)
                    {
                        Console.WriteLine("はずれ\n近づいた\n");
                    }
                    else if (b == a)
                        {
                        Console.WriteLine("はずれ\n変わらない\n");
                        }
                    else
                    {
                        Console.WriteLine("はずれ\n遠くなった\n");
                    }
                }
                a = b;
            }
            Console.WriteLine($"答えは{answer}でした");
        }
    }
}
