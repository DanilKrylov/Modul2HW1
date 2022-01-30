using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW
{
    public static class Starter
    {
        public static void Run()
        {
            Random random = new Random();
            var logger = Logger.GetLogger();

            Result result = null;
            for (int i = 0; i < 100; i++)
            {
                switch (random.Next(1, 4))
                {
                    case 1:
                        result = Actions.InfoLogg();
                        break;
                    case 2:
                        result = Actions.WarningLogg();
                        break;
                    case 3:
                        result = Actions.ErrorLogg();
                        break;
                }
                if (!result.Status)
                {
                    LoggInfo loggInfo = new LoggInfo(DateTime.Now, "Error", $"Action failed by a reason: {result.Message}");

                    logger.AddLogg(loggInfo);
                }
            }

            var loggs = new StringBuilder(); 
            foreach(LoggInfo elem in logger.GetLoggs())
            {
                loggs.Append(elem.ToString() + "\n");
            }

            File.WriteAllText("logg.txt", loggs.ToString());
        }
    }
}
