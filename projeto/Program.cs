// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//V1.0
//V2.0 
Console.WriteLine("Lucas");

//V2.1
WriteCubes();

void WriteCubes()
{
  Console.WriteLine(Cube(3));    // 27
  Console.WriteLine(Cube(4));    // 64
  Console.WriteLine(Cube(5));    // 125

  int Cube(int value) => value * value * value;   // Método local
}
