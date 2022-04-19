using System;

namespace ConsoleApp1
{
    class ex12
    {
        static void Main(string[] args)
        {
            Console.WriteLine("幅を入力してください");
            var width = int.Parse(Console.ReadLine());
            Console.WriteLine("高さを入力してください");
            var height = int.Parse(Console.ReadLine());

            if (width <= 0 || width >= 21 || height <= 0 || height >= 21)
            {
                Console.WriteLine("入力エラー");
            }
            else
            {
                Console.WriteLine("長方形");
                for (var i = 1; i <= height; i++)
                {
                    for (var n = 1; n <= width; n++)
                    {
                        Console.Write("■");
                    }
                    Console.WriteLine();
                }

                Console.WriteLine("横縞");

                for (var i = 1; i <= height; i++)
                {
                    for (var n = 1; n <= width; n++)
                    {
                        if (i % 2 == 1)
                        {

                            Console.Write("■");
                        }
                        else
                        {
                            Console.Write("□");
                        }
                    }
                    Console.WriteLine();
                }

                Console.WriteLine("縦縞");

                for (var i = 1; i <= height; i++)
                {
                    for (var n = 1; n <= width; n++)
                    {
                        if (n % 2 == 1)
                        {
                            Console.Write("■");
                        }
                        else
                        {
                            Console.Write("□");
                        }
                    }
                    Console.WriteLine();
                }

                Console.WriteLine("間抜け");

                for (var i = 1; i <= height; i++)
                {
                    for (var n = 1; n <= width; n++)
                    {
                        if (i == 1 || i == height || n == 1 || width == n)
                        {
                            Console.Write("■");
                        }
                        else
                        {
                            Console.Write("  ");
                        }
                    }
                    Console.WriteLine();
                }

                Console.WriteLine("直角三角形");

                for (var i = 1; i <= height; i++)
                {
                    float a = (float)i / height * width;

                    for (var n = 1; n <= a; n++)
                    {
                        Console.Write("■");
                    }
                    Console.WriteLine();
                }

                Console.WriteLine("チェック");

                for (var i = 1; i <= height; i++)
                {
                    for (var n = 1; n <= width; n++)
                    {
                        if ((i + n) % 2 == 1)
                        {
                            Console.Write("■");
                        }
                        else
                        {
                            Console.Write("□");
                        }
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
