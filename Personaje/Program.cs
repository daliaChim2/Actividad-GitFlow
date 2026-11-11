
using Personaje.personajes;
Personajes personajes = new Personajes()
{
    Nombre = "Wildbloom",
    Vida = 56,
    Ataque = 75,
    Defensa = 95,
    Nivel = 5
};

Console.WriteLine("--- Datos del Personaje ---");
Console.WriteLine($"Nombre: {personajes.Nombre}");
Console.WriteLine($"Vida: {personajes.Vida}");
Console.WriteLine($"Ataque: {personajes.Ataque}");
Console.WriteLine($"Defensa: {personajes.Defensa}");
Console.WriteLine($"Nivel: {personajes.Nivel}");