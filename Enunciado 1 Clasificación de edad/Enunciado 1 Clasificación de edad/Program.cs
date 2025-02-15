int edad;

Console.WriteLine("Ingrese su edad");
edad = Convert.ToInt32(Console.ReadLine());

if (edad < 12)
{
    Console.WriteLine("Usted es un niño");
}
else if (edad >= 12 && edad < 17)
{
    Console.WriteLine("Usted es un adolecente");
}
else if (edad >= 18 && edad < 59)
{
    Console.WriteLine("Usted es un adulto");
}
else if (edad >= 60)
{
    Console.WriteLine("Usted es adulto mayor");
}
