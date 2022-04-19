using System;

namespace Ex25
{
    class Ex25
    {
        static void Main(string[] args)
        {
            int max = 1000;
            int min = 0;
            float turtle;
            float crane;

            while (true)
            {
                float head = InputFloat("頭", max, min);
                float leg = InputFloat("足", max, min);
                
                if (TurtleCrane(head, leg, out turtle, out crane))
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

        /// <summary>
        /// 正確な数値が入力されるまで繰り返す。
        /// </summary>
        /// <param name="message">頭、足</param>
        /// <param name="max">1000</param>
        /// <param name="min">0</param>
        /// <param name="mes">もう一度入力してください。</param>
        /// <returns>正しい入力だった場合入力された値を返す。</returns>
        static int InputFloat(string message, int max, int min, string mes = "もう一度入力してください。")
        {
            int value;
            while (true)
            {
                Console.WriteLine($"{message}の数を入力してください(整数で{min}～{max})");
                try
                {
                    value = int.Parse(Console.ReadLine());
                    if (value >= min && value < max)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"入力エラー。入力範囲外です。{mes}");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine($"正確な数字が入力されませんでした。{mes}");
                }
                catch (OverflowException)
                {
                    Console.WriteLine($"オーバーフローしました。{mes}");
                }
            }
            return value;
        }

        /// <summary>
        /// 亀と鶴の数を求める。
        /// </summary>
        /// <param name="head">頭の数</param>
        /// <param name="leg">足の数</param>
        /// <param name="turtle">亀の数</param>
        /// <param name="crane">鶴の数</param>
        /// <returns>Checkで返ったtrue、falesを返す。</returns>
        static bool TurtleCrane(float head, float leg, out float turtle, out float crane)
        {
            turtle = (leg / 2) - head;
            crane = head - turtle;
            bool i = Check(turtle, crane);
            return i;
        }

        /// <summary>
        /// 鶴と亀の数が自然数かどうかチェックする。
        /// </summary>
        /// <param name="turtle">亀の数</param>
        /// <param name="crane">鶴の数</param>
        /// <returns>亀の数と鶴の数が自然数だったらtrue、それ以外ならfalse。</returns>
        static bool Check(float turtle, float crane)
        {
            bool i;
            if (turtle < 0 || crane < 0 || turtle - Math.Floor(turtle) != 0 || crane - Math.Floor(crane) != 0)
            {
                i = false;
            }
            else
            {
                i = true;
            }
            return i;
        }
    }
}
