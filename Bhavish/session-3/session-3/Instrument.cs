using System;


//Write a program to create a base class called MusicInstrument with common members like name, brand, model, price and inherit the same into sub classes like

//Guitar - with members like bodyStyle, scaleLength, FretSize
//Keyboard - with members like totalKeys, totalPresets, hasAuxSupport
//Drums - with members like material, totalDrums, bassDrumFrequency, snareDrumFrequency
//Create few methods called Assemble() and Play() in each of the sub classes.
namespace session_3
{
    internal abstract class MusicInstrument
    {
        public string _name { get; set; }
        public string? _brand { get; set; }
        public string? _model { get; set; }
        public string? _price { get; set; }
        public abstract void Assemble();
        public abstract void Play();
    }
}
