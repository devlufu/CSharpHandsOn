

namespace session_3
{
    internal class Guitar : MusicInstrument
    {
        public string? _bodyStyle { get; set; }
        public int? _scaleLength { get; set; }
        public int? _fretSize { get; set; }
        public override void Assemble()
        {
            Console.WriteLine($"the {_name} is assembled\n");
        }
        public override void Play()
        {
            Console.WriteLine($"the {_name}is being played");
            Console.WriteLine($"the {_name} has a {_bodyStyle} bodystyle\n");
        }

    }
}
