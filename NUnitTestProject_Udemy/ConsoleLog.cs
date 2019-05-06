using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitTestProject_Udemy
{
    class ConsoleLog : ILog
    {
        public void Write(string message)
        {
            Console.WriteLine(message);
        }
    }
}
