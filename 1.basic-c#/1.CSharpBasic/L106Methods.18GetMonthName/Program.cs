

class Program
{
    /// <summary>
    /// enter month integer number and return month as string use switch case
    /// </summary>
    /// <param name="month"></param>
    /// <returns></returns>

    public static string GetMonthName(int month)
    {
        switch (month)
        {
            case 1:
                return "January";
            case 2:
                return "February";
            case 3:
                return "March";
            case 4:
                return "April";
            case 5:
                return "May";
            case 6:
                return "June";
            case 7:
                return "July";
            case 8:
                return "August";
            case 9:
                return "September";
            case 10:
                return "October";
            case 11:
                return "November";
            case 12:
                return "December";
            default:
                return "";
        }
    }

    public static void Main(string[] args)
    {
        int month = 3;
        Console.WriteLine(GetMonthName(month));
    }
}