ArrayMethod();
Console.WriteLine();
// ----------------
ListMethod();
Console.WriteLine();

// ----------------
ArraySlicing();

void ListMethod()
{
    Random random = new();
    List<int> list = [1, 2, 3, 4];

    list = [.. list.OrderBy(x => random.Next(1, 4))];

    Console.WriteLine("Generate list: ");
    PrintList(list);

    Console.WriteLine("Add");
    list.Add(1);
    PrintList(list);
    Console.WriteLine("Insert");
    list.Insert(0, 1);
    PrintList(list);
    Console.WriteLine("Delete");
    list.Remove(2);
    PrintList(list);

    list.RemoveAll(x => x.Equals(1));
    PrintList(list);
}

void ArrayMethod()
{

    int[] array = new int[10];
    array = GenerateArray(array);
    array[0] = 9;

    Console.WriteLine("Generate array: ");
    PrintArray(array);

    Console.WriteLine("Add");
    var newArray = Add(1, array);
    PrintArray(newArray);

    Console.WriteLine("Insert");
    newArray = insert(2, 1, array);
    PrintArray(newArray);

    Console.WriteLine("Delete");
    newArray = delete(9, array);
    PrintArray(newArray);

}

int[] Add(int value, int[] array)
{
    int[] newArray = new int[array.Length + 1];
    for (int i = 0; i < array.Length; i++)
    {
        newArray[i] = array[i];
    }
    newArray[newArray.Length - 1] = value;
    return newArray;
}

int[] insert(int value, int position, int[] array)
{
    int[] newArray = new int[array.Length + 1];

    for (int i = 0, j = 0; i < newArray.Length; i++)
    {
        if (i == position)
        {

            newArray[i] = value;
        }
        else
        {
            newArray[i] = array[j++];
        }
    }
    return newArray;
}

int[] delete(int value, int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == value)
        {
            count++;
        }
    }
    int[] newArray = new int[array.Length - count];
    for (int i = 0, j = 0; i < array.Length; i++)
    {
        if (array[i] == value) continue;
        newArray[j++] = array[i];
    }
    return newArray;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int[] GenerateArray(int[] array)
{
    Random random = new();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(1, 10);
    }
    return array;
}

void PrintList(List<int> list)
{
    list.ForEach(x =>
    {
        Console.Write(x + " ");
    });
    Console.WriteLine();
}

void ArraySlicing()
{
    Console.WriteLine("Array Slicing: ");
    int[] source = [1, 2, 3, 4, 5];
    PrintArray(source);
    int[] slice = new int[5 - 1];
    Array.Copy(source, 1, slice, 0, slice.Length);
    PrintArray(slice);

    slice = new int[5 - 1];
    Array.Copy(source, slice, slice.Length);
    PrintArray(slice);
}