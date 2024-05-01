class Program
{

    public static void Main()
    {
        int[] array = { 67, 92, 153, 15 };
        int[] result = array.Where(x => x > 30 && x < 100).ToArray();
        for (int i = 0; i < result.Length; i++) 
        {
            Console.WriteLine("{0} ", result[i]);
        }
    }

}
