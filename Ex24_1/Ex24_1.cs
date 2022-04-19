using System;

namespace Ex24_1
{
    class Ex24_1
    {
        static void Main(string[] args)
        {
            int max = 1000;
            int min = 0;
            float head = 0;
            float leg = 0;
            float turtle = 0;
            float crane = 0;
            int check = 0;

            while (true)
            {
                head = InputFloat("頭の数を入力してください(整数で0～1000)", max, min);
                leg = InputFloat("足の数を入力してください(整数で0～1000)", max, min);
                turtle = Turtles(head, leg);
                crane = Cranes(head, leg);
                check = Check(turtle, crane);
                if (check == 1)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("正常な値が出ませんでした。もう一度入力しなおしてください。");
                }
            }
            Console.WriteLine($"亀の数{turtle}匹\n鶴の羽数{crane}羽");
        }

        static int InputFloat(string message, int max, int min)
        {
            int value = 0;
            while (true)
            {
                Console.WriteLine(message);
                try
                {
                    value = int.Parse(Console.ReadLine());
                    if (value >= min && value < max)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("入力エラー。入力範囲外です、もう一度入力してください。");
                    }
                }
                catch(FormatException)
                {
                    Console.WriteLine("正確な数字が入力されませんでした。もう一度入力してください。");
                }
                catch(OverflowException)
                {
                    Console.WriteLine("オーバーフローしました。もう一度入力してください。");
                }
            }
            return value;
        }

        static float Turtles(float head, float leg)
        {
            var number = (leg / 2) - head;
            return number;
        }

        static float Cranes(float head, float leg)
        {
            var number = head - Turtles(head, leg);
            return number;
        }

        static int Check(float turtle, float crane)
        {
            int i;
            if (turtle < 0 || crane < 0 || turtle - Math.Floor(turtle) != 0 || crane - Math.Floor(crane) != 0)
            {
                i = 0;
            }
            else
            {
                i = 1;
            }
            return i;
        }
    }
}
