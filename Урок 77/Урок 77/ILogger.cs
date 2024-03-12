using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Урок_77
{
    public interface ILogger
    {
        void Log(LogLevel logLevel, string messege);
        void LogError(string message)
        {
            Log(LogLevel.Error, message);
        }
        
    }
}
    