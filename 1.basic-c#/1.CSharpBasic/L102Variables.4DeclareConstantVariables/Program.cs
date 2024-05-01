class Program
{
    /// <summary>
    /// 
    /// </summary>
    public static void DeclareConstant()
    {
        const bool varValue1 = true;
        const int varValue2 = 1;
        const decimal varValue3 = 10.22m;
        const double varValue4 = 100.12d;
        const float varValue5 = 0.3f;
        const char varValue6 = 'a';
        const string varValue7 = "truong";
        const long varValue8 = 1200l;
        const ulong varValue9 = 1200ul;
        const uint varValue10 = 10u;
    }
    private static void Main(string[] args)
    {
        DeclareConstant();
    }
}