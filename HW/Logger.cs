using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW
{
    class Logger
    {
        private static Logger _logger;

        private StringBuilder Loggs { get;set; } = new StringBuilder();

        private Logger()
        {

        }

        public static Logger GetLogger()
        {
            if(_logger == null)
            {
                _logger = new Logger();
            }
            return _logger;
        }

        public void AddLogg(string logg)
        {
            Console.WriteLine(logg);
            Loggs.Append(logg + "\t");
        }
        public string GetLoggs()
        {
            return Loggs.ToString();
        }
    }
}
