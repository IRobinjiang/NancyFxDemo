using Nancy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NancyConsole.Module
{
    public class HomeModule:NancyModule
    {
        public HomeModule()
        {
            Get["/"] = r =>
            {
                var os = System.Environment.OSVersion;
                return "Hello Nancy<br/> System:" + os.VersionString;
            };
        }
    }
}
