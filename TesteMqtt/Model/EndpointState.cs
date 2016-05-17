using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteMqtt.Model
{
    class EndpointState
    {
        public bool Powered { get; set; }
        public float Brightness { get; set; }
        public int Hue { get; set; }
        public int Saturation { get; set; }
        public int Kelvin { get; set; }
        public AbilityEnum Ability { get; set; }

        public enum AbilityEnum { DIM, COLOR, NONE }

    }
}
