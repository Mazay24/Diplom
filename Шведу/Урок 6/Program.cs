using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Урок_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] mar = new int[15];
            Random rnd = new Random();
            for (int i = 0; i < mar.Length; i++)
            {
                mar[i] = rnd.Next(15);
                Console.Write(mar[i] + "\t");
            }
            ArrayList zxc = new ArrayList();
            zxc.Add(mar[0]);
            Console.WriteLine();
            for (int i = 0; i < mar.Length; i++)
            {
                int k = 0; //Счётчик!!!

                for (int j = 0; j < zxc.Count; j++)
                {
                    if (mar[i] == (int)zxc[j])

                    {
                        k++;
                        break;
                    }
                }
                if (k == 0)
                {
                    zxc.Add(mar[i]);
                }
            }
            Console.WriteLine("В массиве " + zxc.Count + " различных чисел");
        }
    }
}
