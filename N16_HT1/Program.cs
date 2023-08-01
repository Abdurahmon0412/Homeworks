using N16_HT1;
using System.ComponentModel;
using System.Reflection.Metadata;
using System.Xml.Linq;

//- bitta object yarating, speed va trajectory ni har xil qiymatlarga o'zgartirib ekranga chiqaring

var AirPlane = new Spaceship("Boing97",1000);
AirPlane.Speed = 1000;
AirPlane.Trajectory = 250000;
Console.WriteLine(AirPlane);
AirPlane.Speed = 2000;
AirPlane.Trajectory = 241100;
Console.WriteLine(AirPlane);



