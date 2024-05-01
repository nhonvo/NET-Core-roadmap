// 9. Write a program that initializes a 2D array of integers with values from 1 to 100, then finds and prints the average of the values in the array. Expected output: The average of all the values in the array is: [average]
int[,] array = new int[3, 3];
Random rand = new Random();
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = rand.Next(1, 100);
    }
}
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
        sum += array[i, j];
    }
}
System.Console.WriteLine(sum+" "+array.Length);
Console.WriteLine("The average of all the values in the array is: {0} ", Convert.ToDouble(sum) / Convert.ToDouble(array.Length));