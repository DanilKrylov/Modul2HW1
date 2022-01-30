
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW
{
    public static class Actions
    {
        public static Result InfoLogg()
        {
            Logger logger = Logger.GetLogger();

            LoggInfo loggInfo = new LoggInfo(DateTime.Now, "Info", "Start method: InfoLogg");

            logger.AddLogg(loggInfo);

            return new Result(true);
        }
        public static Result WarningLogg()
        {
            Logger logger = Logger.GetLogger();

            LoggInfo loggInfo = new LoggInfo(DateTime.Now, "Warning", "Skipped logic in method: WarningLogg");

            logger.AddLogg(loggInfo);

            return new Result(true);
        }
        public static Result ErrorLogg()
        {
            return new Result(false, "I broke a logic");
        }
    }
}
