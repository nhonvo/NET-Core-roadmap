namespace TrainningExamTest
{
    public class ArticleSummary
    {
        public static string GetArticleSummary(string content, int maxLength)
        {
            if (string.IsNullOrEmpty(content) || maxLength <= 0)
            {
                return "";
            }

            if (content.Length <= maxLength)
            {
                return content;
            }

            int cutoffIndex = maxLength;

            // If the cutoff index falls within a word, shift it to the previous space
            if (char.IsLetterOrDigit(content[cutoffIndex]))
            {
                cutoffIndex = content.LastIndexOf(' ', cutoffIndex);

                if (cutoffIndex == -1)
                {
                    // If no space was found, use the original cutoff index
                    cutoffIndex = maxLength;
                }
            }

            // Add three dots to the end of the summary
            return content.Substring(0, cutoffIndex) + "...";
        }

    }
}
