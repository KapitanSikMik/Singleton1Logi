using System;
using System.Collections.Generic;

namespace Singleton_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Log.Instance.LogMessage("rejestr zdarzenie 1");
            Log.Instance.LogMessage("rejestr zdarzenie 2");
            Log.Instance.LogMessage("rejestr zdarzenie 3");
            Log.Instance.LogMessage("rejestr zdarzenie 4");

            List<string> log = Log.Instance.GetLog();
            
                Console.WriteLine("Logi:");
                foreach(string message in log)
                {
                    Console.WriteLine(message);
                }
            
            
        }

        
        
    }
}
