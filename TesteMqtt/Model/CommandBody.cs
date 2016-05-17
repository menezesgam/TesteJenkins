using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteMqtt.Model
{
    class CommandBody
    {
        public string From { get; set; }
        public DateTime TimeStamp { get; set; }
        public EndpointState State { get; set; }
    }
}
