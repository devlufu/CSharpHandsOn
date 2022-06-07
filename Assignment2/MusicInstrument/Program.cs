using MusicIntruments;

Guitar device1 = new Guitar();
Keyboard device2 = new Keyboard();
Drums device3 = new Drums();

device1.Name = "Guiter";
device1.Brand = "Nexon";
device1.BodyStyle = "Asthetic";

device2.Name = "Keyboard";
device2.Brand = "Yostar";
device2.TotalKeys = 264;

device3.Name = "Drum";
device3.Brand = "Drmpster";
device3.Material = "Leather";

device1.Play();
device2.Play();
device3.Play();