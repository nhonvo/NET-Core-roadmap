using System.Text;
class Program
{
    /// <summary>
    /// summary content method summary content follow max length
    /// get length of  character without  white space
    /// if length in loop negative  break  and assign  length = maxlength
    /// then substring them from 0 to maxLength input
    /// append "..." as output format
    /// </summary>
    /// <param name="content"></param>
    /// <param name="maxLength"></param>
    /// <returns></returns>
    static public string GetArticleSummary(string content, int maxLength)
    {
        if (string.IsNullOrEmpty(content))
            return "";
        
        if (maxLength >= content.Length)
            return content;
        
        if (maxLength == 0)
            return "...";

        int length = maxLength;
        while (content[length] != ' ')
        {
            length--;
            if (length <= 0)
            {
                length = maxLength;
                break;
            }
        }
        StringBuilder result = new StringBuilder(content.Substring(0, length));
        return result.Append("...").ToString();
    }


    public static void Main(string[] args)
    {
        //  test case 
        // 1. normal
        string content = "One of the world's biggest festivals hit the streets of London";
        int maxLength = 50;
        string result = GetArticleSummary(content, maxLength);
        Console.WriteLine(result);

        // 2.one result 
        string one = "One of the world's biggest festivals hit the streets of London";
        int oneLength = 1;
        string oneResult = GetArticleSummary(one, oneLength);
        Console.WriteLine(oneResult);

        // 3.Empty 
        string empty = "";
        int emptyLength = 5;
        string emptyResult = GetArticleSummary(empty, emptyLength);
        Console.WriteLine(emptyResult);

        // 4.Null
        string nullcontent = null;
        int nullLength = 50;
        string nullResult = GetArticleSummary(nullcontent, nullLength);
        Console.WriteLine(nullResult);

    }
}