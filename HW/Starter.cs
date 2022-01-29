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
                    var logger = Logger.GetLogger();
                    logger.AddLogg(DateTime.Now.ToString() + $" Warning Action failed by a reason: {result.Message}\n");
                }
            }

            var loggs = Logger.GetLogger();

            
            File.WriteAllText("log.txt", loggs.GetLoggs());
        }
    }
}
