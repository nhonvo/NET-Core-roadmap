// 3. Write a program that initializes a 2D array of characters with the letters of the alphabet in order and prints the array to the console. Expected output: a b c d e f g h i j k l m n o p q r s t u v w x y z
// char[] array2 = new char[26];
// for (int i = 0; i < array2.Length; i++)
// {
//     array2[i] = Convert.ToChar(i + 65);
//     Console.Write("{0}, ", Char.ToLower(array2[i]));
// }
char[,] array = { { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm' },
    {'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' }};
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {

        Console.Write("{0} ", array[i, j]);
    }

}