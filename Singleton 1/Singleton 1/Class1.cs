using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton_1
{
    class Log
    {
        private static Log instance = null;

        private Log() { }


        public static Log Instance
        {
            get
            {
                if (instance is null)
                {
                    instance = new Log();
                }
                return instance;
            }
        }

        private List<string> messages = new List<string>();

        public void LogMessage(string message)
        {
            messages.Add(message);
        }

        public List<string> GetLog()
        {
            return messages;
        }
        
    }
}
