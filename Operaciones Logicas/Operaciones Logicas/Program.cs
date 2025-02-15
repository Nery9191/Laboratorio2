using System.ComponentModel.Design;

int num1;
int num2;
int opcion;
int edad;

Console.WriteLine("Seleccione ingrese 1 para compara dos numeros o 2 para validar su edad para votar");
int opcion = int.Parse(Console.ReadLine());
if (opcion == 0)
{
    Console.WriteLine("Opcion no valida");
    return;
    {
        if (opcion == 1) ;
    }
        Console.WriteLine("Ingrese dos numeros para compararlos");
        Console.WriteLine("Ingrese el primer numero");
        while (!int.TryParse(Console.ReadLine(), out num1))
        {
            Console.WriteLine("Entrada no válida. Ingrese un número entero válido.");
        }
        Console.WriteLine("Ingrese el segundo numero");
        while (!int.TryParse(Console.ReadLine(), out num2))
        {
            Console.WriteLine("Entrada no válida. Ingrese un número entero válido.");
        }

        if (num1 > num2)
        {
            Console.WriteLine("El numero 1 es mayor que el numero 2");
        }
        else if (num1 < num2)
        {
            Console.WriteLine("El numero 1 es menor que el numero 2");

        }
        else
        {
            Console.WriteLine("El numero 1 es igual al numero 2");
        }
    }
        else if (opcion == 2)
    {
        int edad;
        Console.WriteLine("Ingrese su edad");
        while (!int.TryParse(Console.ReadLine(), out edad))
        {
            Console.WriteLine("Entrada no válida. Ingrese un número entero válido.");
        }
        if (edad >= 18)
        {
            Console.WriteLine("Usted es mayor de edad y puede votar");
        }
        else
        {
            Console.WriteLine("Usted es menor de edad y no puede votar");
        }
    }
    else
    {
        Console.WriteLine("Opcion no valida");
    }
{
    if (opcion == 2)
    {
        Console.WriteLine("ingrese su edad");
        int edad = int.Parse(Console.ReadLine());
        if (edad >= 18)
        {
            Console.WriteLine("Usted es mayor de edad y puede votar");
        }
        else
        {
            Console.WriteLine("Usted es menor de edad y no puede votar");
        }
        return;
    }
}

