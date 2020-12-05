using System;
using System.IO;
using System.Runtime.CompilerServices;

namespace ErrorLogger
{
    class Program
    {
        static void Main(string[] args)
        {
            IErrorLogger iLogger = new ErrorEvent();
            iLogger.ErrorEventHandler += iLogger.OnErrorEventHandler;
            iLogger.ErrorLogger("System Error");
            
        }
    }
}
