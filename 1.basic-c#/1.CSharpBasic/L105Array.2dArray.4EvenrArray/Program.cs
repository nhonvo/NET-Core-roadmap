// 4. Write a program that initializes a 2D array of integers with values from 1 to 25 and prints only the even numbers to the console. Expected output: 2 4 6 8 10 12 14 16 18 20 22 24

int[,] array = { { 1, 2, 3, 4, 5 }, { 6, 7, 8, 9, 10 }, { 11, 12, 13, 14, 15 }, { 16, 17, 18, 19, 20 }, { 21, 22, 23, 24, 25 } };

for (int i = 0; i < array.GetLength(0); i++)

{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        if (array[i, j] % 2 == 0)
            Console.Write("{0} ", array[i, j]);
    }
}
