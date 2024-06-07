using System;
while (true){
    Console.Write("Enter the length of the square: ");
string heightUserInput = Console.ReadLine();
int height = Convert.ToInt32(heightUserInput);

Console.Write("Enter the width of the square: ");
string widthUserInput = Console.ReadLine();
int width = Convert.ToInt32(widthUserInput);

for (int i = 0; i < height; i++)
{
    for (int j = 0; j < width; j++)
    {
        Console.Write(" *");
    }
    Console.WriteLine();
}

Console.Write("Enter the height of the triangle: ");
string heightTriangleUserInput = Console.ReadLine();
int triangleHeight = Convert.ToInt32(heightTriangleUserInput);
Console.WriteLine();

for (int i = 0; i < triangleHeight; i++)
{
    for (int j = 0; j <= i; j++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}

Console.WriteLine();

for (int i = 0; i < triangleHeight; i++)
{
    for (int j = triangleHeight; j > i; j--)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}

Console.WriteLine();

for (int i = 0; i < triangleHeight; i++)
{
    for (int j = triangleHeight; j > i; j--)
    {
        Console.Write(" ");
    }
    for (int j = 0; j <= i; j++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}

Console.WriteLine();

for (int i = 0; i < triangleHeight; i++)
{
    for (int j = 0; j <= i; j++)
    {
        Console.Write(" ");
    }

    for (int j = triangleHeight; j > i; j--)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}
     Console.WriteLine("Do you want to use the program again? 👉 y/n 👈"); 
    string answer = Console.ReadLine(); 
    
    if (answer.ToLower() != "y") 
    { 
        break; 
    } 
    else 
    { 
        Console.WriteLine("Thank you for using the program 🤝"); 
    } 



}