using System;

namespace Ex22
{
    class Ex22
    {
        static void Main(string[] args)
        {
            float r = 0;　//半径
            float Min = 1;
            float rMax = 100;
            float h = 0; //高さ
            float hMax = 300;
            float s = 0; //底面積
            float v = 0; //体積

            //ここに処理を追加
            r = InputProcessing($"半径を入力してください。\n範囲は{Min}から{rMax}", Min, rMax);
            h = InputProcessing($"高さを入力してください。\n範囲は{Min}～{hMax}", Min, hMax);
            s = GetCircleSurface(r);
            v = GetCylinderVolume(r, h);

            Console.WriteLine("底面積は{0},体積は{1}", s, v);
        }
        static float GetCircleSurface(float radius)
        {  //半径から円の面積を求める
            float surface = 0;
            //　ここに処理を追加
            surface = (float)Math.PI * radius * radius;
            return surface;
        }
        static float GetCylinderVolume(float radius, float height)
        {  //半径と高さから円柱の体積を求める
            float volume = GetCircleSurface(radius) * height;
            return volume;
        }
        static float InputProcessing(string message, float Min, float Max)
        {
            float value = 0;
            while (true)
            {
                Console.WriteLine(message);
                value = float.Parse(Console.ReadLine());
                if (value >= Min && value < Max)
                { //値は適正
                    break;
                }
                else
                {
                    Console.WriteLine("入力エラー。もう一度入力してください。");
                }
            }
            return value;
        }
    }
}
