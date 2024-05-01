using System.Collections;

Stack stack1 = new Stack();
stack1.Push(3);
stack1.Push(4);
stack1.Pop();
foreach (var item in stack1.ToArray())
{
    System.Console.WriteLine(item);
}
Stack<int> s = new Stack<int>(4);
s.Push(1);
s.Push(2);
s.Push(3);

s.Pop();
s.Push(4);
s.Pop();
s.Pop();

Console.WriteLine(s.ToString());

StackArray<string> stack = new StackArray<string>(5);

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
public class Stack<T>(int max)
{
    private readonly int _max = max;
    private readonly List<T> _stack = new List<T>(max);

    public void Push(T item)
    {
        if (_stack.Count > _max)
        {
            throw new InvalidOperationException("Stack overflow");
        }
        else
        {
            _stack.Add(item);
        }
    }

    public T Pop()
    {
        if (_stack.Count <= 0)
        {
            throw new InvalidOperationException("Stack overflow");
        }
        _stack.RemoveAt(_stack.Count - 1);
        return _stack.Last();
    }

    public override string ToString()
    {
        string str = "";
        for (int i = 0; i < _stack.Count; i++)
        {
            str += _stack[i] + " ";
        }
        return str;
    }
}
public class StackArray<T>
{
    private int _maxSize { get; set; }
    private int _index { get; set; } = -1;
    private T[] _stack { get; set; }
    public StackArray(int maxSize)
    {
        this._maxSize = maxSize;
        _stack = new T[maxSize];
    }
    /// <summary>
    /// add element to stack, increase index when index  = 0 stack has
    /// 1 element
    /// </summary>
    /// <param name="item"></param>
    /// <exception cref="InvalidOperationException"></exception>
    public void Push(T item)
    {
        if (_index == _stack.Length - 1)
        {
            throw new InvalidOperationException("Can not push");
        }
        else
        {
            _index++;
            _stack[_index] = item;
        }
    }
    /// <summary>
    /// removes and returns the item at the top of stack.
    /// decrease the index
    /// </summary>
    /// <returns></returns>
    /// <exception cref="InvalidOperationException"></exception>
    public T Pop()
    {
        if (_index == -1)
        {
            throw new InvalidOperationException("Cannot pop item from an empty stack.");
        }
        else
        {
            T item = _stack[_index];
            _index--;
            return item;
        }
    }
    /// <summary>
    /// return the first element from stack
    /// </summary>
    /// <returns></returns>
    /// <exception cref="InvalidOperationException"></exception>
    public T Peek()
    {
        if (_index == -1)
        {
            throw new InvalidOperationException("Cannot peek at an empty stack.");
        }
        return _stack[_index];
    }
    /// <summary>
    /// when stack empty index  = -1 so when stack has 1 element 
    /// count() = 0, -1 + 1
    /// </summary>
    /// <returns></returns>
    public int Count()
    {
        return _index + 1;
    }
    /// <summary>
    /// set the array to new empty array and set _maxSize = 0
    /// </summary>
    public void Clear()
    {
        Array.Clear(_stack, 0, _maxSize);
        _index = -1;
    }

}