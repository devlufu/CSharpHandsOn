// See https://aka.ms/new-console-template for more information
using session_3;
var guitar =new Guitar();
guitar._name = "Guitar";
guitar._bodyStyle = "Brazilian";
guitar.Assemble();
guitar._brand = "Fender";
guitar.Play();

var keyboard = new Keyboard();
keyboard._name = "Keyboard";
keyboard._brand = "Roland";
keyboard._totalPresets = 15;
keyboard._hasAuxSupport = true;
keyboard.Play();
keyboard.Assemble();

var drum = new Drums();
drum._name = "Drum";
drum._brand = "Bang";
drum._totalDrums = 23;
drum._bassDrumFrequency = 60.0;
drum._snareDrumFrequency = 170;
drum._material = "leather";
drum.Assemble();

