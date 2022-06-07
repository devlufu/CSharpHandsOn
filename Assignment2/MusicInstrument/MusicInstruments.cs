namespace MusicIntruments
{
    public class MusicIntrument
    {
        public string? Name;
        public string? Brand;
        public string? Model;
        public string? Price;
    }
    public class Guitar : MusicIntrument
    {
        public string? BodyStyle;
        public int? ScaleLength;
        public string? FretSize;

        public void Assemble()
        {
            Console.WriteLine($"Assembling {Name} of body style {BodyStyle}");
        }
        public void Play()
        {
            Console.WriteLine($"playing {Name} from {Brand}");
        }
    }

    public class Keyboard : MusicIntrument
    {
        public int? TotalKeys;
        public int? TotalPresets;
        public bool? HasAuxSupport;

        public void Assemble()
        {
            Console.WriteLine($"Assembling {Name} of total keys {TotalKeys}");
        }
        public void Play()
        {
            Console.WriteLine($"playing {Name} from {Brand}");
        }
    }

    public class Drums : MusicIntrument
    {
        public string? Material;
        public int? TotalDrums;
        public int? BassDrumFrequency;
        public int? SnareDrumFrequency;


        public void Assemble()
        {
            Console.WriteLine($"Assembling {Name} of Material {Material}");
        }
        public void Play()
        {
            Console.WriteLine($"playing {Name} from {Brand}");
        }
    }
}