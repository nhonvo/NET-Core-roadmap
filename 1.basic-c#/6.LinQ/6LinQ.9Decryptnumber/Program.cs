class Program
{

    public static void Main()
    {
        var chars = new char[] { ')', '!', '@', '#', '$', '%', '^', '&', '*', '(' };

        var encryptedNumber = "#(@*%)$(&$*#&";
        //compare with char array get index in char array and join it to string
        var decryptedNumber = string.Join("", encryptedNumber.Select(c => Array.IndexOf(chars, c)));

        Console.WriteLine(decryptedNumber);
    }

}
