using System;


string heightUserInput = Console.ReadLine();
int height = Convert.ToInt32(heightUserInput);  

string widthUserInput = Console.ReadLine();
int width = Convert.ToInt32(widthUserInput);

for (int i = 0; i < height; i++)
{
    Console.WriteLine();

    for (int j = 0; j < width; j++)
    {
        Console.Write(" *");
    }
}

Console.WriteLine();
string heightTriangleUserInput = Console.ReadLine();
int triangleHeight = Convert.ToInt32(heightTriangleUserInput); 


for (int i = 0; i < triangleHeight; i++)
{
    Console.WriteLine();

    for (int j = 0; j <= i; j++)
    {
        Console.Write(" *");
    }
}