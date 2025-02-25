// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello!");

Console.WriteLine("Grid 20x20:");

// 20x20 grid
int[,] grid = new int[20, 20];
Random rand = new Random();

// Fill grid with random numbers between 0 and 99
for (int i = 0; i < 20; i++)
{
    for (int j = 0; j < 20; j++)
    {
        grid[i, j] = rand.Next(0, 100);
    }
}

// Display grid in the console
for (int i = 0; i < 20; i++)
{
    for (int j = 0; j < 20; j++)
    {
        Console.Write(grid[i, j].ToString().PadLeft(3) + " ");
    }
    Console.WriteLine();
}

// Coordinates of the highest and lowest numbers
int minValue = grid[0, 0];
int maxValue = grid[0, 0];
int minX = 0, minY = 0;
int maxX = 0, maxY = 0;

for (int i = 0; i < 20; i++)
{
    for (int j = 0; j < 20; j++)
    {
        if (grid[i, j] < minValue)
        {
            minValue = grid[i, j];
            minX = i;
            minY = j;
        }
        if (grid[i, j] > maxValue)
        {
            maxValue = grid[i, j];
            maxX = i;
            maxY = j;
        }
    }
}

// Output the coordinates and values
Console.WriteLine("");
Console.WriteLine($"Lowest number: {minValue}. Array coordinates: [{minX}], [{minY}]");
Console.WriteLine($"Highest number: {maxValue}. Array coordinates [{maxX}], [{maxY}]");

// Flatten grid's 2D array into a 1D array
int[] flatGrid = new int[20 * 20];
int index = 0;
for (int i = 0; i < 20; i++)
{
    for (int j = 0; j < 20; j++)
    {
        flatGrid[index++] = grid[i, j];
    }
}

// Sort it
Array.Sort(flatGrid);

// Display sorted grid in the console
Console.WriteLine("");
Console.WriteLine("Grid 20x20 (low to high):");
index = 0;
for (int i = 0; i < 20; i++)
{
    for (int j = 0; j < 20; j++)
    {
        Console.Write(flatGrid[index++].ToString().PadLeft(3) + " ");
    }
    Console.WriteLine();
}