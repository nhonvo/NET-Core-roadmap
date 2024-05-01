using MiniProject.Stack;

// 1. Adding items to the stack using the Push method
// 2. Removing items from the stack using the Pop method
// 3. Retrieving the item at the top of the stack using the Peek method
// 4. Retrieving the number of items in the
// 5. Clearing all items from the stack using the Clear method
// 6. Make sure to test edge cases such as adding and removing items from an empty stack, adding and removing multiple items from the stack, and testing that the Count method returns the correct number of items after adding and removing items.

class Program
{

    public static void Main(string[] args)
    {
        StackProject<string> stack = new StackProject<string>(5);

        // adding items 
        stack.Push("nhon");
        stack.Push("nam");
        stack.Push("hoa");
        stack.Push("mai");
        stack.Push("Duy");

        string topItem = stack.Peek();
        Console.WriteLine("The top item is {0}", topItem);

        string poppedItem = stack.Pop();
        Console.WriteLine("Popped item: {0}", poppedItem);
        
        int itemCount = stack.Count();
        Console.WriteLine($"Number of items in the stack: {itemCount}");

        stack.Clear();
        Console.WriteLine("Clear all items from the stack");

    }
}