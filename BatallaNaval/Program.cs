using System.Runtime.InteropServices;


Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("BATALLA NAVAL");
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine("Jugador 1");
Console.WriteLine("Seleccione la forma en la que desea ubicar el barco:   0=vertical  1=horizontal");
string boatposition = Console.ReadLine();


Console.WriteLine("Ingrese la longitud del barco (Tablero de 5x5)");
string boatlength = Console.ReadLine();


Console.WriteLine("Ingrese las coordenadas del barco de la forma ===> x,y");


string sea = " ~ ";

int n = 10;

    if (n > 10 || n <= 0)
    {
        n = 10;
    }
    int a = n;
    int b = n;
    int[,] arrayTablero = new int[a, b];

    for (int i = 0; i < arrayTablero.GetLength(0); i++)
    {
        for (int j = 0; j < arrayTablero.GetLength(1); j++)
        {
            Console.Write(sea);
        }
        Console.Write("\n");
}

    string boatstart = Console.ReadLine();
string[] coordinates = boatstart.Split(',');



Console.WriteLine($"x= {coordinates[0]}");
Console.WriteLine($"y= {coordinates[1]}");

Console.WriteLine("Ingrese cualquier tecla para continuar");
Console.ReadLine();
Console.Clear();


string fail = "X";
string goal = "0";


Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("JUGADOR 2");
Console.WriteLine("Ataca al barco enemigo, ingrese la ubicación de la forma ===> x,y ");

if (n > 10 || n <= 0)
{
    n = 10;
}

for (int i = 0; i < arrayTablero.GetLength(0); i++)
{
    for (int j = 0; j < arrayTablero.GetLength(1); j++)
    {
        Console.Write(sea);
    }
    Console.Write("\n");
}
string boatattack = Console.ReadLine();
string[] coordinatesAttack = boatattack.Split(',');
string x = coordinatesAttack[0];
string y = coordinatesAttack[1];
