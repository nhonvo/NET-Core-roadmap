// 8. Write a program that initializes a 2D array of integers with random values between 1 and 100, then finds and prints the sum of all the values in the array. Expected output: The sum of all the values in the array is: [sum]
int[,] array = new int[3, 3];
Random rand = new Random();
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = rand.Next(1, 100);
    }
}
int sum = 0;
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = rand.Next(1, 100);
        sum += array[i, j];
    }
}
Console.WriteLine("The sum of all the values in the array is: {0} ", sum);