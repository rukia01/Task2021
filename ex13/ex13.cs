using System;

namespace ex13
{
    class ex13
    {
        const int Max = 10;
        const int MaxTime = 3;
        static void Main(string[] args)
        {
            Random rand = new Random();
            var answer = rand.Next(1, Max);
            for(int i = 0; i < MaxTime;i++)
            {
                Console.WriteLine($"いくつでしょうか。あと{MaxTime - i}回");
                var inputNum = int.Parse(Console.ReadLine());
                if (inputNum == answer)
                {
                    Console.WriteLine("当たり");
                    Console.WriteLine($"{6000 / (i + 1)}点");
                    break;
                }
                else if(inputNum > answer)
                {
                    Console.WriteLine("はずれ\nもっと小さい\n");
                }
                else
                {
                    Console.WriteLine("はずれ\nもっと大きい\n");
                }
            }
            Console.WriteLine($"答えは{answer}でした");
        }
    }
}
