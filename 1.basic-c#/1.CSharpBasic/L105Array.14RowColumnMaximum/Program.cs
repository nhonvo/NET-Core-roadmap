

// // 14. Write a program that initializes a 2D array of integers with random values between 1 and 100, then prints the row and column indices of the maximum value in the array to the console. Expected output: The maximum value in the array is located at row [row]
// Console.WriteLine();
int[,] array = new int[3, 3];
Random rand = new Random();
int rows = array.GetLength(0);
int columns = array.GetLength(1);
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        array[i, j] = rand.Next(1, 100);
    }
}
int max = array[0, 0];
int row_max = 0;
int column_max = 0;
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        if (array[i, j] > max)
            max = array[i, j];
    }
}
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        if (array[i, j] == max)
        {
            row_max = i;
            column_max = j;
        }
    }
}
Console.WriteLine("The maximum value in the array is located at row {0} and column {1} ", row_max, column_max);


