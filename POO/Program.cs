// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var apuntador = new Apuntador();
Apuntador apuntadorPlatzi = new Apuntador();
Apuntador apuntadorPlatzi2 = new Apuntador();

apuntadorPlatzi.Color = "Negro";
apuntadorPlatzi2.Color = "Blanco";

class Apuntador
{
    public string Color { get; set; }
    public double Large { get; set; }
    public short CantOfBotton { get; set; }
    public bool HasStickers { get; set; }
}