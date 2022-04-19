using System;

namespace ex15
{
    class ex15
    {
        static void Main(string[] args)
        {
            Console.WriteLine("数を入力");
            var inputNumber = int.Parse(Console.ReadLine());
            string answer;
            int ten = inputNumber / 10;
            int one = inputNumber % 10;
            string[] words0to19 =
                {
                "zero","one","two","three","four","five","six","seven","eight","nine","ten",
                "eleven","twelve","thirteen","forteen","fifteen","sixteen","seventeen","eighteen","nineteen"
                };
            string[] words20 = { "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };
            string[] word1to9 = {" ", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            if (inputNumber>=0&&inputNumber<=99)
            {
                if (inputNumber<20)
                {
                    answer = words0to19[inputNumber];
                    Console.WriteLine(answer);
                }

                else if(one <= 0)
                {
                    Console.WriteLine(words20[ten - 2]);
                }
                else if(inputNumber<=99)
                {
                    answer = words20[ten-2] + "-" + word1to9[one];
                    Console.WriteLine(answer);
                }
            }

            else
            {
                Console.WriteLine("入力エラー");
            }
        }
    }
}
