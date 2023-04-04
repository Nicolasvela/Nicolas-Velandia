using System.ComponentModel.Design;
using System.Runtime.InteropServices;

Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("BATALLA NAVAL");
Console.ForegroundColor = ConsoleColor.White;

string sea = "~";

int n = 10;

if (n > 10 || n <= 0)
{
    n = 10;
}
int a = n;
int b = n;
int[,] arrayTablero = new int[a, b];
Console.WriteLine("  ¦   0  1  2  3  4  5  6  7  8  9");
Console.WriteLine("--+--------------------");

for (int i = 0; i < arrayTablero.GetLength(0); i++)
{
    Console.Write((i).ToString() + " ¦ ");
    for (int j = 0; j < arrayTablero.GetLength(1); j++)
    {
        Console.Write($"  {sea}");
    }
    Console.Write("\n");
}


Console.WriteLine("Seleccione la forma en la que desea ubicar el barco:   0=vertical  1=horizontal");
string boatposition = Console.ReadLine();
string N = "0";
string H = "1";
Console.WriteLine("Ingrese la longitud del barco ");
string boatlength = Console.ReadLine();



Console.WriteLine("Ingrese las coordenadas del barco de la forma ===> x,y");
string boatstart = Console.ReadLine();
string[] coordinates = boatstart.Split(',');
Console.WriteLine($"x= {coordinates[0]}");
Console.WriteLine($"y= {coordinates[1]}");
Console.WriteLine("S= barco");

string x = coordinates[0];
string y = coordinates[1];




string ship = "S";





if (boatposition == N)
{

    Console.WriteLine("  ¦   0  1  2  3  4  5  6  7  8  9");
    Console.WriteLine("--+----------------------------");

    for (int i = 0; i < arrayTablero.GetLength(0); i++)
    {
        Console.Write((i).ToString() + " ¦ ");
        for (int j = 0; j < arrayTablero.GetLength(1); j++)
        {

            if (x == $"{j}" && y == $"{i}")
            {

                Console.Write($"  {ship}");
            }


            else
            {
                Console.Write($"  {sea}");

            }


        }
        Console.Write("\n");
    }
}

// todavida no lo acabo :c