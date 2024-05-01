class Program
{
    /// <summary>
    /// declare 5 data types and 50 variables
    /// </summary>
    public static void DefineVariable()
    {

        bool boolValue1, boolValue2, boolValue3, boolValue4, boolValue5;
        char charValue1, charValue2, charValue3, charValue4, charValue5;
        decimal decimalValue1, decimalValue2, decimalValue3, decimalValue4, decimalValue5;
        double doubleValue1, doubleValue2, doubleValue3, doubleValue4, doubleValue5;
        float floatValue1, floatValue2, floatValue3, floatValue4, floatValue5;
        int intValue1, intValue2, intValue3, intValue4, intValue5;
        string stringValue1, stringValue2, stringValue3, stringValue4, stringValue5;

        (boolValue1, boolValue2, boolValue3, boolValue4, boolValue5) = 
            (false, false, true, true, false);
        (charValue1, charValue2, charValue3, charValue4, charValue5) = 
            ('d', 'a', 'c', 'b', 'e');
        (decimalValue1, decimalValue2, decimalValue3, decimalValue4, decimalValue5) = (10.1m, 50.1m, 30.1m, 40.1m, 20.1m);
        (doubleValue1, doubleValue2, doubleValue3, doubleValue4, doubleValue5) = 
            (11222.33d, 21222.33d, 31222.33d, 41222.33d, 52123.22d);
        (floatValue1, floatValue2, floatValue3, floatValue4, floatValue5) = 
            (0.3f, 0.2f, 0.1f, 0.4f, 0.5f);
        (intValue1, intValue2, intValue3, intValue4, intValue5) = (1, 5, 3, 4, 2);
        (stringValue1, stringValue2, stringValue3, stringValue4, stringValue5) = 
            ("i", "am", "a", "man", "super");
        (boolValue1, boolValue2, boolValue3, boolValue4, boolValue5) = 
            (true, false, false, true, false);
        Console.WriteLine($"{boolValue1}, {boolValue2}, {boolValue3}, {boolValue4}, {boolValue5}");

        (charValue1, charValue2, charValue3, charValue4, charValue5) = 
            ('a', 'b', 'c', 'd', 'e');
        Console.WriteLine($"{charValue1}, {charValue2},{charValue3},{charValue4},{charValue5}");

        (decimalValue1, decimalValue2, decimalValue3, decimalValue4, decimalValue5) = 
            (10.1m, 20.1m, 30.1m, 40.1m, 50.1m);
        Console.WriteLine($"{decimalValue1}, {decimalValue2}, {decimalValue3}, {decimalValue4}, {decimalValue5}");

        (doubleValue1, doubleValue2, doubleValue3, doubleValue4, doubleValue5) = 
            (11222.33d, 21222.33d, 31222.33d, 41222.33d, 52123.22d);
        Console.WriteLine($"{doubleValue1}, {doubleValue2}, {doubleValue3}, {doubleValue4},  {doubleValue5}");

        (floatValue1, floatValue2, floatValue3, floatValue4, floatValue5) = 
            (0.1f, 0.2f, 0.3f, 0.4f, 0.5f);
        Console.WriteLine($"{floatValue1}, {floatValue2}, {floatValue3}, {floatValue4}, {floatValue5}");

        (intValue1, intValue2, intValue3, intValue4, intValue5) = (1, 2, 3, 4, 5);
        Console.WriteLine($"{intValue1}, {intValue2}, {intValue3}, {intValue4}, {intValue5}");

        (stringValue1, stringValue2, stringValue3, stringValue4, stringValue5) = 
            ("i", "am", "a", "super", "man");
        Console.WriteLine($"{stringValue1}, {stringValue2}, {stringValue3}, {stringValue4}, {stringValue5}");

    }
    private static void Main(string[] args)
    {
        DefineVariable();
    }
}