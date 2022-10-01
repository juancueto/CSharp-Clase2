// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
// Ejercicio 1
Console.WriteLine("Ingrese su nombre");
string? nombre = Console.ReadLine();

Console.WriteLine("Ingrese su apellido");
string? apellido = Console.ReadLine();

Console.WriteLine("Ingrese su edad");
string? _edad = Console.ReadLine();
int edad = int.Parse(_edad);

Console.WriteLine("Ingrese su altura en metros");
string? _altura = Console.ReadLine();
decimal altura = decimal.Parse(_altura);

string mensaje = $"Nombre: {nombre}\n" + 
    $"Apellido: {apellido}\n" +
    $"Edad: {edad}\n" +
    $"Altura: {altura}";

Console.WriteLine(mensaje);

// Ejercicio 3
// 3.1
int numero = 18;
if (numero >= 18)
    Console.WriteLine("Es mayor o igual a 18");

// 3.2
char caracter = 'a';
if (caracter == 'a')
    Console.WriteLine("Char es igual a 'a'");

// 3.3
if (numero >= 18 && caracter == 'a')
    Console.WriteLine("Se cumplieron 2 condiciones");

// 3.4
if (numero < 18 && caracter == 'a')
    Console.WriteLine("Se cumplieron 1 condicion de 2");

