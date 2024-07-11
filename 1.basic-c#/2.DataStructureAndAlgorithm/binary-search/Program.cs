int[] sample = [1, 3, 4, 5, 7, 11];
// Test cases
int[][] testCases = {
            [], // Empty array
            [5], // Single element (match)
            // [3], // Single element (no match)
            [1, 3, 5, 7, 9], // Element at the beginning
            [1, 3, 5, 7, 9], // Element in the middle
            [1, 3, 5, 7, 9], // Element at the end
            [1, 3, 5, 7, 9] // Element not present
        };
for (int i = 0 ;i < testCases.Length; i ++ )
{
    Console.WriteLine(BinarySearch(testCases[i], 5));
}
// Console.WriteLine(BinarySearch(sample, 1));

bool BinarySearch(int[] arr, int value)
{
    // sort array: 1, 3, 4, 5, 7, 11

    /*
        1. separate the array to 2 parts
        2. compare middle value with value searched
        3. value searched = middle value => return result
            3.1 value searched > middle value 
                => floorIndex = middle index
            3.2 value searched < middle value 
                => cellingIndex = middle index
        4. Continue
    */
    int floorIndex = 0;
    int cellingIndex = arr.Length;

    while (floorIndex < cellingIndex)
    {
        int distance = cellingIndex - floorIndex;
        int guessIndex = distance / 2;
        int guessValue = arr[guessIndex];

        if (value == guessValue) return true;
        else if (value > guessValue) floorIndex = guessIndex;
        else cellingIndex = guessIndex;
    }
    return false;
}

