using System;

namespace шведов_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] zxc = new int[] { 133, 11, 33, -1, 423, 144, 0, 17, 32, 423, 0, 11, 113, 22, 4 };
            for (int i = 0; i < zxc.Length; i++)
            {
                if (zxc[i] == 0)
                {
                    int qq = i * i;
                    Console.WriteLine(qq);
                }

            }
        }
    }
}
