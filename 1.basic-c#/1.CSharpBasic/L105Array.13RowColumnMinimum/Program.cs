
// 13. Write a program that initializes a 2D array of integers with random values between 1 and 100, then prints the row and column indices of the minimum value in the array to the console. Expected output: The minimum value in the array is located at row [row] and column [column].
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
int min = array[0, 0];
int row_min = 0;
int column_min = 0;
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        if (array[i, j] < min)
            min = array[i, j];
    }
}
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        if (array[i, j] == min)
        {
            row_min = i;
            column_min = j;
        }
    }
}
Console.WriteLine("The minimum value in the array is located at row {0} and column {1} ", row_min, column_min);
