﻿using System.Collections;
using System.Linq.Expressions;

int numdia;

Console.WriteLine("Introduce un número del 1 al 7");
numdia = int.Parse(Console.ReadLine());

Console.WriteLine("El día de la semana es: ");
switch (numdia)
{
    case 1:
        Console.WriteLine("Lunes");
        break;
    case 2:
        Console.WriteLine("Martes");
        break;
    case 3:
        Console.WriteLine("Miércoles");
        break;
    case 4:
        Console.WriteLine("Jueves");
        break;
    case 5:
        Console.WriteLine("Viernes");
        break;
    case 6:
        Console.WriteLine("Sábado");
        break;
    case 7:
        Console.WriteLine("Domingo");
        break;
    default:
        Console.WriteLine("Número incorrecto");
        break;
}