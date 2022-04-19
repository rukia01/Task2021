using System;

namespace Ex21
{
    class Ex21
    {
        static void Main(string[] args)
        {
            string s1 = InputName("名前を入力してください");
            int no = InputNumbers("ほめ指数を入力。\n1～5の間");
            string s2 = Praise(s1, no);
            Console.WriteLine(s2);

        }
        static string Praise(string s ,int index)
        {
            string answer = null;

            if (index >= 1 && index <= 5)
            {
                for (int i = 1; i <= index; i++)
                {
                    if (i == 1)
                    {
                        answer = $"{s}すごい";
                    }
                    else if (i == 2)
                    {
                        answer += $"\r\n{s}よくできました";
                    }
                    else if (i == 3)
                    {
                        answer += $"\r\n{s}大変よくできました";
                    }
                    else if (i == 4)
                    {
                        answer += $"\r\n{s}素晴らしい";
                    }
                    else if (i == 5)
                    {
                        answer += $"\r\n{s}かっこいい";
                    }
                }
            }

            else
            {
                answer = "入力エラー";
            }
            
            return answer;
        }
        static string InputName(string message)
        {
            Console.WriteLine(message);
            string n =Console.ReadLine();
            return n;
        }
        static int InputNumbers(string message)
        {
            Console.WriteLine(message);
            int n = int.Parse(Console.ReadLine());
            return n;
        }
    }
}
