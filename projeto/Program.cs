// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//V1.0
//V2.0 
Console.WriteLine("Lucas");
//V3.0
Console.WriteLine("Lucas - V3.0");
//V4.0
Console.WriteLine("Lucas - V4.0");
//3.1
Console.WriteLine("Lucas - V3.1");
//3.2
Console.WriteLine("Lucas - V3.2");

//V2.1
WriteCubes();

void WriteCubes()
{
  Console.WriteLine(Cube(3));    // 27
  Console.WriteLine(Cube(4));    // 64
  Console.WriteLine(Cube(5));    // 125

  int Cube(int value) => value * value * value;   // Método local
}
