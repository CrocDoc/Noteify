using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Noteify.Configuration.Options
{
    public class Config
    {
        public ConnectionStrings connectionStrings { get; set; }
    }

    public class ConnectionStrings
    {
        public string DefaultConnection { get; set; }
    }
}
