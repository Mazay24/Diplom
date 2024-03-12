using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Урок_73
{
    interface IProvider
    {
        string GetDate();
    }
    interface IProcessor
    {
        void ProcessorDate(IProvider dataProvider);
    }
    class ConsoleProcesser : IProcessor
    {
        public void ProcessorDate(IProvider dataProvider)
        {
            Console.WriteLine(dataProvider.GetDate());
        }
    }
    class DbProvider : IProvider
    {
        public string GetDate()
        {
            return "Данные из БД";
        }
    }
    class FileProvider : IProvider
    {
        public string GetDate()
        {
            return "Данные из файла";
        }
    }
    class APIProvider : IProvider
    {
        public string GetDate()
        {
            return "Данные из API";
        }
        class Program
        {
            static void Main(string[] args)
            {
                IProcessor dataProcessor = new ConsoleProcesser();
                dataProcessor.ProcessorDate(new DbProvider());
                dataProcessor.ProcessorDate(new FileProvider());
                dataProcessor.ProcessorDate(new APIProvider());
            }
        }
    }
}
