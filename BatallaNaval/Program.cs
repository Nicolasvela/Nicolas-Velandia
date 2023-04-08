using System.ComponentModel.Design;
using System.Runtime.InteropServices;



Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("BATALLA NAVAL");

Console.WriteLine("~~~~~║~~~~~~~~");
Console.WriteLine("~~~~▓║~~~~~~~~");
Console.WriteLine("~~~▓▓║~~~~~~~~");
Console.WriteLine("~~▓▓▓║~~~~~~~~");
Console.WriteLine("▀█████████▀~~");
Console.WriteLine("Presione cualquier tecla para continuar :D");
Console.ReadLine();
Console.Clear();




Console.ForegroundColor = ConsoleColor.White;

string sea = "~";
Console.WriteLine("Judador1");

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
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("Min= 2 ----- Max= 5");
Console.ForegroundColor = ConsoleColor.White;
string boatlength = Console.ReadLine();
int Long2 = int.Parse(boatlength) - 1;
int Long3 = int.Parse(boatlength) - 2;
int Long4 = int.Parse(boatlength) - 3;
int Long5 = int.Parse(boatlength) - 4;




Console.WriteLine("Ingrese las coordenadas del barco de la forma ===> x,y");
string boatstart = Console.ReadLine();
string[] coordinates = boatstart.Split(',');
Console.WriteLine($"x= {coordinates[0]}");
Console.WriteLine($"y= {coordinates[1]}");
Console.WriteLine("S= barco");

string x = coordinates[0];
string y = coordinates[1];




string ship = "S";





if (boatposition == N) //vertical
{

    Console.WriteLine("  ¦   0  1  2  3  4  5  6  7  8  9");
    Console.WriteLine("--+----------------------------");

    for (int i = 0; i < arrayTablero.GetLength(0); i++)
    {
        Console.Write((i).ToString() + " ¦ ");

        for (int j = 0; j < arrayTablero.GetLength(1); j++)
        {


            if (boatlength == "2") //barco de 2
            {
                if (x == $"{j}" && y == $"{i}")
                {
                    Console.Write($"  {ship}");
                }

                if (x == $"{j}" && y == $"{i - Long2}")
                {
                    Console.Write($"  {ship}");

                }

                else
                {
                    Console.Write($"  {sea}");
                }

            }


            if (boatlength == "3")// barco de 3
            {
                if (x == $"{j}" && y == $"{i}")
                {
                    Console.Write($"  {ship}");
                }

                if (x == $"{j}" && y == $"{i - Long2}")
                {
                    Console.Write($"  {ship}");
                }

                if (x == $"{j}" && y == $"{i - Long3}")
                {
                    Console.Write($"  {ship}");
                }

                else
                {
                    Console.Write($"  {sea}");
                }
            }


            if (boatlength == "4")// barco de 4
            {
                if (x == $"{j}" && y == $"{i}")
                {
                    Console.Write($"  {ship}");
                }

                if (x == $"{j}" && y == $"{i - Long2}")
                {
                    Console.Write($"  {ship}");
                }

                if (x == $"{j}" && y == $"{i - Long3}")
                {
                    Console.Write($"  {ship}");
                }

                if (x == $"{j}" && y == $"{i - Long4}")
                {
                    Console.Write($"  {ship}");
                }

                else
                {
                    Console.Write($"  {sea}");
                }
            }


            if (boatlength == "5")// barco de 5
            {
                if (x == $"{j}" && y == $"{i}")
                {
                    Console.Write($"  {ship}");
                }

                if (x == $"{j}" && y == $"{i - Long2}")
                {
                    Console.Write($"  {ship}");
                }

                if (x == $"{j}" && y == $"{i - Long3}")
                {
                    Console.Write($"  {ship}");
                }

                if (x == $"{j}" && y == $"{i - Long4}")
                {
                    Console.Write($"  {ship}");
                }

                if (x == $"{j}" && y == $"{i - Long5}")
                {
                    Console.Write($"  {ship}");
                }

                else
                {
                    Console.Write($"  {sea}");
                }
            }


        }
        Console.Write("\n");
    }
}



if (boatposition == H) //horizontal
{

    Console.WriteLine("  ¦   0  1  2  3  4  5  6  7  8  9");
    Console.WriteLine("--+----------------------------");

    for (int i = 0; i < arrayTablero.GetLength(0); i++)
    {
        Console.Write((i).ToString() + " ¦ ");

        for (int j = 0; j < arrayTablero.GetLength(1); j++)
        {


            if (boatlength == "2") //barco de 2
            {
                if (x == $"{j - Long2}" && y == $"{i}")
                {
                    Console.Write($"  {ship}");
                }



                if (x == $"{j}" && y == $"{i}")
                {
                    Console.Write($"  {ship}");

                }

                else
                {
                    Console.Write($"  {sea}");
                }

            }


            if (boatlength == "3")// barco de 3
            {
                if (x == $"{j - Long3}" && y == $"{i}")
                {
                    Console.Write($"  {ship}");
                }

                if (x == $"{j - Long3}" && y == $"{i}")
                {
                    Console.Write($"  {ship}");
                }

                if (x == $"{j}" && y == $"{i}")
                {
                    Console.Write($"  {ship}");
                }

                else
                {
                    Console.Write($"  {sea}");
                }
            }


            if (boatlength == "4")// barco de 4
            {
                if (x == $"{j - Long4}" && y == $"{i}")
                {
                    Console.Write($"  {ship}");
                }

                if (x == $"{j - Long4}" && y == $"{i}")
                {
                    Console.Write($"  {ship}");
                }

                if (x == $"{j - Long4}" && y == $"{i}")
                {
                    Console.Write($"  {ship}");
                }

                if (x == $"{j}" && y == $"{i}")
                {
                    Console.Write($"  {ship}");
                }

                else
                {
                    Console.Write($"  {sea}");
                }
            }


            if (boatlength == "5")// barco de 5
            {
                if (x == $"{j - Long5}" && y == $"{i}")
                {
                    Console.Write($"  {ship}");
                }

                if (x == $"{j - Long5}" && y == $"{i}")
                {
                    Console.Write($"  {ship}");
                }

                if (x == $"{j - Long5}" && y == $"{i}")
                {
                    Console.Write($"  {ship}");
                }

                if (x == $"{j - Long5}" && y == $"{i}")
                {
                    Console.Write($"  {ship}");
                }

                if (x == $"{j}" && y == $"{i}")
                {
                    Console.Write($"  {ship}");
                }

                else
                {
                    Console.Write($"  {sea}");
                }
            }


        }
        Console.Write("\n");
    }
}



Console.WriteLine("Esta es la posición de su barco, presione cualquier tecla para continuar :)");
Console.ReadLine();
Console.Clear();

//JUGADOR 2 :D


string fail = "@";
string goal = "X";


Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("JUGADOR 2");


Console.WriteLine("falla= @");
Console.WriteLine("acierto= X");
Console.WriteLine();

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


int bien = 0; // intentos correctos
int mal = 0; // intentos incorrectos


// disparar


if (boatposition == N) // vertical 
{
    while (bien != int.Parse(boatlength))
    {


        Console.WriteLine("Ataca al barco enemigo, ingrese la ubicación de la forma ===> x,y ");
        string boatattack = Console.ReadLine();
        string[] coordinatesAttack = boatattack.Split(',');
        string xx = coordinatesAttack[0];
        string yy = coordinatesAttack[1];



        Console.WriteLine("  ¦   0  1  2  3  4  5  6  7  8  9");
        Console.WriteLine("--+--------------------");


        for (int i = 0; i < arrayTablero.GetLength(0); i++)
        {
            Console.Write((i).ToString() + " ¦ ");

            for (int j = 0; j < arrayTablero.GetLength(1); j++)
            {



                if (boatlength == "2") //barco de 2
                {


                    if (xx == x && yy == y || xx == x && int.Parse(yy) == int.Parse(y) + 1)
                    {
                        if (xx == $"{j}" && yy == $"{i}")
                        {
                            Console.Write($"  {goal}");
                            bien++;

                        }
                        else
                        {
                            Console.Write($"  {sea}");
                        }

                    }



                    if (xx != x || yy != y && int.Parse(yy) != int.Parse(y) + 1)
                    {
                        if (xx == $"{j}" && yy == $"{i}")
                        {
                            Console.Write($"  {fail}");
                            mal++;
                        }
                        else
                        {
                            Console.Write($"  {sea}");
                        }

                    }

                }


                if (boatlength == "3") //barco de 3
                {


                    if (xx == x && yy == y || xx == x && int.Parse(yy) == int.Parse(y) + 1 || xx == x && int.Parse(yy) == int.Parse(y) + 2)
                    {
                        if (xx == $"{j}" && yy == $"{i}")
                        {
                            Console.Write($"  {goal}");
                            bien++;

                        }
                        else
                        {
                            Console.Write($"  {sea}");
                        }

                    }



                    if (xx != x || yy != y && int.Parse(yy) != int.Parse(y) + 1 && int.Parse(yy) != int.Parse(y) + 2)
                    {
                        if (xx == $"{j}" && yy == $"{i}")
                        {
                            Console.Write($"  {fail}");
                            mal++;
                        }
                        else
                        {
                            Console.Write($"  {sea}");
                        }

                    }

                }

                if (boatlength == "4") //barco de 4
                {


                    if (xx == x && yy == y || xx == x && int.Parse(yy) == int.Parse(y) + 1 || xx == x && int.Parse(yy) == int.Parse(y) + 2 || xx == x && int.Parse(yy) == int.Parse(y) + 3)
                    {
                        if (xx == $"{j}" && yy == $"{i}")
                        {
                            Console.Write($"  {goal}");
                            bien++;

                        }
                        else
                        {
                            Console.Write($"  {sea}");
                        }

                    }



                    if (xx != x || yy != y && int.Parse(yy) != int.Parse(y) + 1 && int.Parse(yy) != int.Parse(y) + 2 && int.Parse(yy) != int.Parse(y) + 3)
                    {
                        if (xx == $"{j}" && yy == $"{i}")
                        {
                            Console.Write($"  {fail}");
                            mal++;
                        }
                        else
                        {
                            Console.Write($"  {sea}");
                        }

                    }

                }

                if (boatlength == "5") //barco de 5
                {


                    if (xx == x && yy == y || xx == x && int.Parse(yy) == int.Parse(y) + 1 || xx == x && int.Parse(yy) == int.Parse(y) + 2 || xx == x && int.Parse(yy) == int.Parse(y) + 3 || xx == x && int.Parse(yy) == int.Parse(y) + 4)
                    {
                        if (xx == $"{j}" && yy == $"{i}")
                        {
                            Console.Write($"  {goal}");
                            bien++;

                        }
                        else
                        {
                            Console.Write($"  {sea}");
                        }

                    }



                    if (xx != x || yy != y && int.Parse(yy) != int.Parse(y) + 1 && int.Parse(yy) != int.Parse(y) + 2 && int.Parse(yy) != int.Parse(y) + 3 && int.Parse(yy) != int.Parse(y) + 4)
                    {
                        if (xx == $"{j}" && yy == $"{i}")
                        {
                            Console.Write($"  {fail}");
                            mal++;
                        }
                        else
                        {
                            Console.Write($"  {sea}");
                        }

                    }

                }



            }


            Console.Write("\n");
            




        }




    }



    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("HAS GANADO");
    Console.WriteLine($"Aciertos =  {bien}");
    Console.WriteLine($"Fallos   =  {mal}");
    Console.Write("Total intentos =  ");
    Console.Write(bien + mal); ;
}//finN






if (boatposition == H) // horizontal 
{
    while (bien != int.Parse(boatlength))
    {


        Console.WriteLine("Ataca al barco enemigo, ingrese la ubicación de la forma ===> x,y ");
        string boatattack = Console.ReadLine();
        string[] coordinatesAttack = boatattack.Split(',');
        string xx = coordinatesAttack[0];
        string yy = coordinatesAttack[1];



        Console.WriteLine("  ¦   0  1  2  3  4  5  6  7  8  9");
        Console.WriteLine("--+--------------------");


        for (int i = 0; i < arrayTablero.GetLength(0); i++)
        {
            Console.Write((i).ToString() + " ¦ ");

            for (int j = 0; j < arrayTablero.GetLength(1); j++)
            {


                if (boatlength == "2") //barco de 2
                {


                    if (xx == x && yy == y || int.Parse(xx) == int.Parse(x) + 1 && yy == y)
                    {
                        if (xx == $"{j}" && yy == $"{i}")
                        {
                            Console.Write($"  {goal}");
                            bien++;
                        }
                        else
                        {
                            Console.Write($"  {sea}");
                        }

                    }

                    if (yy != y || xx != x && int.Parse(xx) != int.Parse(x) + 1)
                    {
                        if (xx == $"{j}" && yy == $"{i}")
                        {
                            Console.Write($"  {fail}");
                            mal++;
                        }
                        else
                        {
                            Console.Write($"  {sea}");
                        }

                    }
                }


                if (boatlength == "3") //barco de 3
                {


                    if (xx == x && yy == y || int.Parse(xx) == int.Parse(x) + 1 && yy == y || int.Parse(xx) == int.Parse(x) + 2 && yy == y)
                    {
                        if (xx == $"{j}" && yy == $"{i}")
                        {
                            Console.Write($"  {goal}");
                            bien++;
                        }
                        else
                        {
                            Console.Write($"  {sea}");
                        }

                    }

                    if (yy != y || xx != x && int.Parse(xx) != int.Parse(x) + 1 && int.Parse(xx) != int.Parse(x) + 2)
                    {
                        if (xx == $"{j}" && yy == $"{i}")
                        {
                            Console.Write($"  {fail}");
                            mal++;
                        }
                        else
                        {
                            Console.Write($"  {sea}");
                        }

                    }
                }

                if (boatlength == "4") //barco de 4
                {


                    if (xx == x && yy == y || int.Parse(xx) == int.Parse(x) + 1 && yy == y || int.Parse(xx) == int.Parse(x) + 2 && yy == y || int.Parse(xx) == int.Parse(x) + 3 && yy == y)
                    {
                        if (xx == $"{j}" && yy == $"{i}")
                        {
                            Console.Write($"  {goal}");
                            bien++;
                        }
                        else
                        {
                            Console.Write($"  {sea}");
                        }

                    }

                    if (yy != y || xx != x && int.Parse(xx) != int.Parse(x) + 1 && int.Parse(xx) != int.Parse(x) + 2 && int.Parse(xx) != int.Parse(x) + 3)
                    {
                        if (xx == $"{j}" && yy == $"{i}")
                        {
                            Console.Write($"  {fail}");
                            mal++;
                        }
                        else
                        {
                            Console.Write($"  {sea}");
                        }

                    }
                }

                if (boatlength == "5") //barco de 5
                {


                    if (xx == x && yy == y || int.Parse(xx) == int.Parse(x) + 1 && yy == y || int.Parse(xx) == int.Parse(x) + 2 && yy == y || int.Parse(xx) == int.Parse(x) + 3 && yy == y || int.Parse(xx) == int.Parse(x) + 4 && yy == y)
                    {
                        if (xx == $"{j}" && yy == $"{i}")
                        {
                            Console.Write($"  {goal}");
                            bien++;
                        }
                        else
                        {
                            Console.Write($"  {sea}");
                        }

                    }

                    if (yy != y || xx != x && int.Parse(xx) != int.Parse(x) + 1 && int.Parse(xx) != int.Parse(x) + 2 && int.Parse(xx) != int.Parse(x) + 3 && int.Parse(xx) != int.Parse(x) + 4)
                    {
                        if (xx == $"{j}" && yy == $"{i}")
                        {
                            Console.Write($"  {fail}");
                            mal++;
                        }
                        else
                        {
                            Console.Write($"  {sea}");
                        }

                    }
                }




            }
            Console.Write("\n");





        }




    }



    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("HAS GANADO");
    Console.WriteLine($"Aciertos =  {bien}");
    Console.WriteLine($"Fallos   =  {mal}");
    Console.Write("Total intentos =  ");
    Console.Write(bien + mal); ;
}//finH