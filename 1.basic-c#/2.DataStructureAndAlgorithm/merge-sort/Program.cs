// int[] source = [11, 3, 4, 2, 5, 7, 6, 12];
// var (begin, end) = (4, 8);
// int[] destination = new int[end - begin];
// Array.Copy(source, begin, destination, 0, destination.Length);

// foreach (var item in destination)
// {
//     Console.Write(item + " ");
// }
// Console.WriteLine();

Random rand = new();
int size = 100;
int[] sample = new int[size];
for (int i = 0; i < size; i++)
{
    sample[i] = rand.Next(1, 100);
}
sample = [.. sample.OrderBy(x => rand.Next())];
foreach (var item in sample)
{
    Console.Write(item + " ");
}
Console.WriteLine();

// Initial Array
// [11, 3, 4, 2, 5, 7, 6, 12]

// Step 1: Divide the Array
//               [11, 3, 4, 2, 5, 7, 6, 12]
//               /                      \
//       [11, 3, 4, 2]                [5, 7, 6, 12]

// Step 2: Recursively Divide Each Half
//         /         \                 /         \
//   [11, 3]       [4, 2]         [5, 7]       [6, 12]

// Step 3: Continue Splitting Until Single Elements
//      /    \      /    \         /    \        /    \
//   [11]  [3]  [4]  [2]    [5] [7]   [6] [12]

// Step 4: Merge Single Elements into Sorted Subarrays
//        \    /      \    /       \    /         \    /
//      [3, 11]   [2, 4]   [5, 7]   [6, 12]

// Step 5: Merge Sorted Subarrays
//             \         /             \         /
//         [2, 3, 4, 11]           [5, 6, 7, 12]

// Step 6: Merge Final Sorted Halves
//                   \            /
//              [2, 3, 4, 5, 6, 7, 11, 12]


// Actually không hoàn toàn theo thứ tự từ trên xuống mà từ trái sang phải rồi mới đi dần xuống.
// Final Sorted Array
// [2, 3, 4, 5, 6, 7, 11, 12]

sample = MergeSort(sample);
foreach (var item in sample)
{
    Console.Write(item + " ");
}
Console.WriteLine();
Console.WriteLine(IsSorted(sample));
// Make sub-array of the given "source" array,
// from "begin" inclusive to "end" exclusive
T[] MakeSubarray<T>(T[] source, int begin, int end)
{
    T[] destination = new T[end - begin];
    if (destination.Length > 0)
    {
        Array.Copy(source, begin, destination, 0, destination.Length);
    }

    return destination;
}

int[] MergeSort(int[] arrayToSort)
{
    // BASE CASE: arrays with fewer than 2 elements are sorted
    if (arrayToSort.Length < 2)
    {
        return arrayToSort;
    }

    // STEP 1: divide the array in half
    // We use integer division, so we'll never get a "half index"
    int midIndex = arrayToSort.Length / 2;

    int[] left = MakeSubarray(arrayToSort, 0, midIndex);
    int[] right = MakeSubarray(arrayToSort, midIndex, arrayToSort.Length);

    // STEP 2: sort each half
    int[] sortedLeft = MergeSort(left);
    int[] sortedRight = MergeSort(right);

    // STEP 3: merge the sorted halves
    int[] sortedArray = new int[arrayToSort.Length];

    int currentLeftIndex = 0;
    int currentRightIndex = 0;

    for (int currentSortedIndex = 0; currentSortedIndex < arrayToSort.Length; currentSortedIndex++)
    {
        // sortedLeft's first element comes next
        // if it's less than sortedRight's first
        // element or if sortedRight is exhausted
        if (currentLeftIndex < sortedLeft.Length
                && (currentRightIndex >= sortedRight.Length || sortedLeft[currentLeftIndex] < sortedRight[currentRightIndex])
            )

        // currentLeftIndex < sortedLeft.Length: This ensures that there are still elements to be processed in sortedLeft.
        // currentRightIndex >= sortedRight.Length: This handles the case where sortedRight is completely processed, so the remaining elements in sortedLeft can be directly added to sortedArray.
        {
            sortedArray[currentSortedIndex] = sortedLeft[currentLeftIndex];
            currentLeftIndex++;
        }
        else
        {
            sortedArray[currentSortedIndex] = sortedRight[currentRightIndex];
            currentRightIndex++;
        }
    }

    return sortedArray;
}

bool IsSorted(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > array[i++])
            return false;
    }
    return true;
}