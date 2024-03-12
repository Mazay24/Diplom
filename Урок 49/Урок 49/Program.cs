using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Урок_49
{
    class Program
    {
        static void Main(string[] args)
        {
            int? i = 55;

            Console.WriteLine(i == null); //Проверяется равенство с null!!!
            Console.WriteLine(i.HasValue);//Проверяет есть ли в переменной какие небудь данные!!!
            Console.WriteLine(i.GetValueOrDefault()); //Выводит значение переменной, если данных
                                                      //нет то выводится дефолтное знчение 0!!!
            Console.WriteLine(i.GetValueOrDefault(3)); //В данном случае дефолтное значение 3!!!
            Console.WriteLine(i ?? 14);//Те же действия что и выше!!!
            Console.WriteLine(i.Value);//Выводит реальное значение переменой, если же null то 
            // будет ошибка!!!
        }
    }
}
