using System;

namespace Challenge03
{
    class Challenge03
    {
        static char[] t = new char[7] { 'I', 'O', 'S', 'Z', 'J', 'L', 'T' };
        static char[,] minoPattern = new char[5040, 7];
        static int minoPatternId = 0;
        static char b = ' ';
        static char n = ' ';
        static void Main(string[] args)
        {

            //全部を用意すると5040個の配列を用意する
            //List<char> tl = new List<char>(t);
            char[] tl = new char[t.Length];
            Array.Copy(t, tl, t.Length);

            char[] s = new char[t.Length];

            for (int i0 = 0; i0 < t.Length; i0++)
            {   //先頭の文字を切り替えて処理する
                //List<char> l1 = new List<char>(tl); //残りの文字のリストでl1を作る
                char[] l1 = new char[tl.Length - 1];
                s[0] = t[i0];   // 完成させる配列sの先頭に文字を入れる
                Array.Copy(tl, 0, l1, 0, i0); //前半部のコピー
                Array.Copy(tl, i0 + 1, l1, i0, l1.Length - i0); //後半部のコピー
                                                                //l1.Remove(t[i0]);   //完成させる配列sに入れた文字をl1から取り除く                

                for (int i1 = 0; i1 < l1.Length; i1++)
                {  //先頭の文字を切り替えて処理する
                    char[] l2 = new char[l1.Length - 1]; //残りの文字のリストl1からl2を作る
                    s[1] = l1[i1]; // 完成させる配列sの先頭に文字を入れる　
                    Array.Copy(l1, 0, l2, 0, i1); //前半部のコピー
                    Array.Copy(l1, i1 + 1, l2, i1, l2.Length - i1); //後半部のコピー

                    for (int i2 = 0; i2 < l2.Length; i2++)
                    {
                        char[] l3 = new char[l2.Length - 1];
                        s[2] = l2[i2];
                        Array.Copy(l2, 0, l3, 0, i2); //前半部のコピー
                        Array.Copy(l2, i2 + 1, l3, i2, l3.Length - i2); //後半部のコピー

                        for (int i3 = 0; i3 < l3.Length; i3++)
                        {
                            char[] l4 = new char[l3.Length - 1];
                            s[3] = l3[i3];
                            Array.Copy(l3, 0, l4, 0, i3); //前半部のコピー
                            Array.Copy(l3, i3 + 1, l4, i3, l4.Length - i3); //後半部のコピー

                            for (int i4 = 0; i4 < l4.Length; i4++)
                            {
                                char[] l5 = new char[l4.Length - 1];
                                s[4] = l4[i4];
                                Array.Copy(l4, 0, l5, 0, i4); //前半部のコピー
                                Array.Copy(l4, i4 + 1, l5, i4, l5.Length - i4); //後半部のコピー

                                for (int i5 = 0; i5 < l5.Length; i5++)
                                {
                                    char[] l6 = new char[l5.Length - 1];
                                    s[5] = l5[i5];
                                    Array.Copy(l5, 0, l6, 0, i5); //前半部のコピー
                                    Array.Copy(l5, i5 + 1, l6, i5, l6.Length - i5); //後半部のコピー
                                    for (int i6 = 0; i6 < l6.Length; i6++)
                                    {
                                        s[6] = l6[i6];
                                        // Console.Write($"{ minoPatternId.ToString()}:");
                                        for (int i7 = 0; i7 < s.Length; i7++)
                                        {
                                            minoPattern[minoPatternId, i7] = s[i7];
                                            // Console.Write(minoPattern[minoPatternId, i7]);
                                        }
                                        minoPatternId++;
                                        // Console.WriteLine();
                                    }
                                }
                            }
                        }
                    }
                }
            }
            //　全パターン作成が完了、20パターンをランダムで抽出


            for (int i = 0;i <= 5039; i++)
            {
                Random rund = new Random();
                int f = rund.Next(i, 5040);
                for (int a = 0;a <= 6;a++)
                {
                    b = minoPattern[i, a];
                    n = minoPattern[f, a];
                    minoPattern[f, a] = b;
                    minoPattern[i, a] = n;
                }
            }

            for (int e = 0;e <= 19;e++)
            {
                for (int u = 0;u <= 6;u++)
                {
                    Console.Write(minoPattern[e, u]);
                }
                Console.WriteLine(" ");
            }
        }
    }
}
