using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session_3
{
    internal class Keyboard : MusicInstrument
    {
        public int? _totalKeys { get; set; }
        public int? _totalPresets { get; set; }
        public bool _hasAuxSupport { get; set; }
        public override void Assemble()
        {
            Console.WriteLine($"the {_name} is assembled it has {_totalPresets} number of presets\n");
            if (_hasAuxSupport)
                Console.WriteLine("it has AUX support\n");
            else
                Console.WriteLine("no AUX support\n");
        }
        public override void Play()
        {
            Console.WriteLine($"the {_name} is being played\n");
        }

    }
}
