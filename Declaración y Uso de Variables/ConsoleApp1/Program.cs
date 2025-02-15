int numeroentero;
double numerodecimal;
string cadenatexto;
bool valorverdadero;

Console.WriteLine("introduce un numero entero");
numeroentero = int.Parse(Console.ReadLine());

Console.WriteLine("introduce un numero decimal");
numerodecimal = double.Parse(Console.ReadLine());

Console.WriteLine("intoduce una cadena de texto");
cadenatexto = Console.ReadLine();

Console.WriteLine("introduce un valor verdadero");
valorverdadero = bool.Parse(Console.ReadLine());

Console.WriteLine("los valores introducidos son:");
Console.WriteLine(numeroentero);
Console.WriteLine(numerodecimal);
Console.WriteLine(cadenatexto);
Console.WriteLine(valorverdadero);  

