int[,] array = new int[3, 3];
Random rand = new Random();
int rows = array.GetLength(0);
int columns = array.GetLength(1);
int max = array[0, 0];
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        array[i, j] = rand.Next(1, 100);
    }
}
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        if (array[i, j] > max)
            max = array[i, j];
    }
}
Console.WriteLine("The largest value in the array is: {0} ", max);