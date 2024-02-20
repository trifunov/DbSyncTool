using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbSyncTool.Core.Models
{
    public class CustomerSettings
    {
        public string SourceConnectionString { get; set; }

        public string TargetConnectionString { get; set; }

        public string CustomerName { get; set; }
    }
}
