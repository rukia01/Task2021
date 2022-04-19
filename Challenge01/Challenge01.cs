using System;

namespace Chareng01
{
    class Chareng01
    {


        static void Main(string[] args)
        {

            int pigeon = 0;
            int evolutionPoppo = 0;
            int evolutionCandy = 12;

            Console.WriteLine("ポッポの数を入力");
            int poppo = int.Parse(Console.ReadLine());
            Console.WriteLine("飴の数を入力");
            int candy = int.Parse(Console.ReadLine());

            for (; ; )
            {
                if (poppo > 0 && candy >= evolutionCandy)
                {
                    candy -= evolutionCandy;
                    poppo -= 1;
                    pigeon += 1;
                    evolutionPoppo += 1;
                }

                else if (poppo > 0 && candy + pigeon >= evolutionCandy)
                {
                    candy += pigeon;
                    pigeon = 0;
                    candy -= evolutionCandy;
                    poppo -= 1;
                    pigeon += 1;
                    evolutionPoppo += 1;
                }

                else if (poppo > 1 && candy + poppo + pigeon > evolutionCandy)
                {
                    candy += pigeon;
                    pigeon = 0;
                    poppo -= evolutionCandy - candy;
                    candy += evolutionCandy - candy;
                    candy -= evolutionCandy;
                    poppo -= 1;
                    pigeon += 1;
                    evolutionPoppo += 1;
                }

                else
                {
                    candy += pigeon;
                    break;
                }
            }

            Console.WriteLine($"進化できた回数{evolutionPoppo}回");
            Console.WriteLine($"残りのポッポ{poppo}羽");
            Console.WriteLine($"残りの飴{candy}個");
        }
    }
}
