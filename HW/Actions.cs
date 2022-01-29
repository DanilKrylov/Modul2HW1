
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

            logger.AddLogg(DateTime.Now.ToString() + " Info Start method: InfoLogg \n");

            return new Result(true);
        }
        public static Result WarningLogg()
        {
            Logger logger = Logger.GetLogger();

            logger.AddLogg(DateTime.Now.ToString() + " Warning Skipped logic in method: WarningLogg \n");

            return new Result(true);
        }
        public static Result ErrorLogg()
        {
            return new Result(false, "I broke a logic");
        }
    }
}
