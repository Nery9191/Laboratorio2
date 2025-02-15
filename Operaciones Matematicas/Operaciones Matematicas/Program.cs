int num1;
int num2;

Console.WriteLine("ingrese un numero");
num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese otro numero");
num2 = int.Parse(Console.ReadLine());

Console.WriteLine("La suma de los numeros es: " + (num1 + num2));
Console.WriteLine("La resta de los numeros es: " + (num1 - num2));
Console.WriteLine("La multiplicacion de los numeros es: " + (num1 * num2));
Console.WriteLine("La division de los numeros es: " + (num1 / num2));   

Console.WriteLine("Presione cualquier tecla para salir");
Console.ReadKey();

