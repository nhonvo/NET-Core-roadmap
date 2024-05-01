// 5. Write a program that initializes a 2D array of strings with names of countries and their capitals, then prints each country and its capital to the console. Expected output: USA Washington D.C. France Paris Japan Tokyo Mexico Mexico City
string[,] array = { { "USA Washington D.C", "France Paris" }, { "Japan Tokyo", "Mexico Mexico City" } };
foreach (string country in array)
{
    Console.Write("{0} ", country);
}