using System;

namespace Challenge02
{
    class Challenge02
    {
        static void Main(string[] args)
        {
            int zhou = 20;
            Random rnd = new Random();
            

            char[] tetris = { 'T', 'I', 'O', 'S', 'Z', 'J', 'L' };
            char[,] wave = new char[zhou,tetris.Length];
            for(var i = 0;i < zhou;i++)
            {
                bool sin = false;
                while(!sin)
                {
                    for (var a = 0; a < tetris.Length; a++)
                    {
                        wave[i, a] = tetris[a];
                    }

                    for (var a = 0; a < tetris.Length - 1; a++)
                    {
                        var tetrisMino1 = ' ';
                        var tetrisMino2 = rnd.Next(a, tetris.Length);
                        tetrisMino1 = wave[i, a];
                        wave[i, a] = wave[i, tetrisMino2];
                        wave[i, tetrisMino2] = tetrisMino1;

                    }
                }
                

                //重複確認
                var t = 0;
                for (; t < i; t++)
                {
                    var c = 0;
                    for (; c < tetris.Length; c++)
                    {
                        if (wave[i, c] != wave[t, c])
                        {
                            break;
                        }
                    }
                    if(c == tetris.Length)
                    {
                        break;
                    }

                }
                if (t == i)
                {
                    sin = true;
                }

                Console.Write($"{i + 1}週目");
                for (var a = 0; a < tetris.Length; a++)
                {

                    Console.Write(wave[i,a]);
                    Console.Write(" ");

                }

                Console.WriteLine(" ");

            }
        }
    }
}
