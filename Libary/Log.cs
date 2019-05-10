using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;
using log4net.Config;
using System.IO;

namespace Lib
{
    public static class Log
    {
        private static ILog LOG;

        static Log()
        {
            XmlConfigurator.ConfigureAndWatch(new FileInfo(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile));
            LOG = LogManager.GetLogger(typeof(Log));
        }

        public static ILog log { get => LOG; }
    }
}
