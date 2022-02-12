using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegexAss
{
    public class Nlog
    {
        private readonly static Logger logger=LogManager.GetCurrentClassLogger();
        public static void ErrorInfo(string message)
            { logger.Error(message); }

        public  static void SuccessLog(string message)
        {
            logger.Info(message);
        }
    }
}
