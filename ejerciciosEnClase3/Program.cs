// See https://aka.ms/new-console-template for more information
Console.WriteLine("Precio por utilizar el estacionamiento");
Console.WriteLine("Seleccione 1 si ha permanecido los primeros 60 min");
Console.WriteLine("Seleccione 2 si ha permanecido las primeras 2 horas");
Console.WriteLine("Seleccione 3 si ha permanecido más de dos horas");

int number;
int opt = int.Parse(Console.ReadLine()) ;

switch (opt)
{
    case 1: number = 5;break;
    case 2: number = 15; break;
    default: number = 40; break;
}
Console.WriteLine($"Debe la cantidad de ${number}.00");

