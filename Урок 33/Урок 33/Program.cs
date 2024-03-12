using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Урок_33
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,,] myArray =  //Создание трёхмерного массива!
           {
                {
                    { 2, 4, 7},
                    { 55, 78, 2 }
                },

                {
                    { 12, 45, 7},
                    { 13, 48, 2}
                },

                {
                    { 5, 12, 60 },
                    { 4, 20, 14 }
                }

            };
              Console.WriteLine(myArray[0,1,0]); // Вводим данные в этот в элемент массива!
                                               
        }
        
 }   }   
