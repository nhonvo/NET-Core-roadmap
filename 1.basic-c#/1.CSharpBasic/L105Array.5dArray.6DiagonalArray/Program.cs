// // 6. Write a program that initializes a 2D array of integers with values from 1 to 16 and prints the diagonal elements of the array to the console. Expected output: 1 6 11 16
int[,] array = { { 1, 2, 3, 4 },
                    { 5, 6, 7, 8 },
                    { 9, 10, 11, 12 },
                    { 13, 14, 15, 16 } };
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        if (i == j)
            Console.Write("{0}  ", array[i, j]);
    }
}
