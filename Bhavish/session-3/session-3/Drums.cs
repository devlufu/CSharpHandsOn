using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session_3
{
    internal class Drums : MusicInstrument
    {
        public int? _totalDrums { get; set; }
        public string? _material { get; set; }
        public double? _bassDrumFrequency { get; set; }
        public double? _snareDrumFrequency { get; set; }
        public override void Assemble()
        {
            Console.WriteLine($"the {_name} is assembled with {_material} material , {_bassDrumFrequency} bassdrum frequency and  {_snareDrumFrequency } of snare drum frequency.");
            Console.WriteLine($"there are total {_totalDrums} drums\n ");
        }
        public override void Play()
        {
            Console.WriteLine($"the {_name}is being played \n");
        }

    }
}
