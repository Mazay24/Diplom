using System;

namespace Урок_77
{
    class Program
    {
        static void Main(string[] args)
        {
            ILogger cons = new Consolle();
            cons.Log(LogLevel.Debug, "some event");
            cons.Log(LogLevel.Warning, "some warning");
            cons.Log(LogLevel.Fatal, "some fatal error");
            cons.LogError("some error");
        }
    }
}
