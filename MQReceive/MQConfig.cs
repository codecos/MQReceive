using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MQReceive
{
    public class MQConfig
    {
        public static string HostName = ConfigurationManager.AppSettings["HostName"];
        public static string UserName = ConfigurationManager.AppSettings["UserName"];
        public static string Password = ConfigurationManager.AppSettings["Password"];
    }
}
