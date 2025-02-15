string usuario = "Nery";
string password = "1234";

Console.WriteLine("Este es un programa de prueba, el usuario es Nery y la contraseña 1234");
Console.WriteLine("Ingrese su usuario");
string Inputusuario = Console.ReadLine();
Console.WriteLine("Ingrese su contraseña");
string Inputpassword = Console.ReadLine();
if (password == null)
{
    Console.WriteLine("Error: No se ingresó la contraseña");
}
else if (usuario == usuario && password == password)
{
    Console.WriteLine("Bienvenido");
}
else
{
    Console.WriteLine("Error: Usuario o contraseña incorrectos");
}