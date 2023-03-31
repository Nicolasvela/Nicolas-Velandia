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
            Console.Write(" ~ ");
        }
        Console.Write("\n");
    }






    string boatstart = Console.ReadLine();
string[] coordinates = boatstart.Split(',');    

