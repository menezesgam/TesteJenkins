using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteMqtt.Model
{
    class CommandHeader
    {

        public string CloudDomain { get; set; }
        public long HouseHoldID { get; set; }
        public long LocationID { get; set; }
        public MessageTypeEnum MessageType { get; set; }
        public MessageSubjectEnum MessageSubject { get; set; }
        public long MessageSubjectID { get; set; }

        public enum MessageTypeEnum { CONTROL, STATUS }
        public enum MessageSubjectEnum { ENDPOINTS }
    }
}
