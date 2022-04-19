using System;

namespace EX25_1
{
    class EX25_1
    {
        static void Main(string[] args)
        {
            float turtle;
            float crane;

            TurtleCrane(out turtle, out crane);

            Console.WriteLine($"亀の数{turtle}匹\n鶴の羽数{crane}羽");
        }

        static void TurtleCrane(out float turtle, out float crane)
        {
            int max = 1000;
            int min = 0;
            int check;
            float head;
            float leg;

            while (true)
            {
                head = InputFloat("頭の数を入力してください(整数で0～1000)", max, min);
                leg = InputFloat("足の数を入力してください(整数で0～1000)", max, min);
                turtle = (leg / 2) - head;
                crane = head - turtle;
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
        }
        static int InputFloat(string message, int max, int min)
        {
            int value;
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
                catch (FormatException)
                {
                    Console.WriteLine("正確な数字が入力されませんでした。もう一度入力してください。");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("オーバーフローしました。もう一度入力してください。");
                }
            }
            return value;
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
