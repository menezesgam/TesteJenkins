using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteMqtt.CommandPattern
{
    public class MicroChip
    {
        public Command[] reqCommands;
        public Command[] resCommands;

        public static int GetInt()
        {
            return 2;
        }
    }
}
