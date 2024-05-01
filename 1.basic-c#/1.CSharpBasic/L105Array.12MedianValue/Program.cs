// 12. Write a program that initializes a 2D array of integers with random values between 1 and 100, then finds and prints the median value in the array. Expected output: The median value in the array is: [median value]
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
int[] tmpArray = new int[rows * columns];
int Index = 0;
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        tmpArray[Index++] = array[i, j];
    }
}
Array.Sort(tmpArray);
int arrayLength = rows * columns;
int arrayNumber1 = tmpArray[arrayLength / 2];
int arrayNumber2 = (tmpArray[arrayLength / 2 - 1] + tmpArray[arrayLength / 2]);
Console.WriteLine("The median value in the array is: {0}", (arrayLength % 2 != 0 ? arrayNumber1 : arrayNumber2 / 2.0));
