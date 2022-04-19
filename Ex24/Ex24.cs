using System;

namespace Ex24
{
    class Ex24
    {
        static void Main(string[] args)
        {
            int max = 1000;
            int min = 0;
            int head = 0;
            int leg = 0;
            int turtle = 0;
            int crane = 0;
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
            string value;
            int i = 0;
            while (true)
            {
                Console.WriteLine(message);
                value = Console.ReadLine();
                bool result = int.TryParse(value, out i);
                if (result)
                {
                    if (i >= min && i < max)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("入力エラー。入力範囲外です、もう一度入力してください。");
                    }
                }
                else
                {
                    Console.WriteLine("入力エラー。半角数字で入力してください。");
                }
            }
            return i;
        }

        static int Turtles(int head, int leg)
        {
            var number = (leg / 2) - head;
            return number;
        }

        static int Cranes(int head, int leg)
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
