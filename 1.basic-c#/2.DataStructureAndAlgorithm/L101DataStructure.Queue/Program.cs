using System.Collections;

Queue queue1 = new Queue();
queue1.Enqueue(1);
queue1.Enqueue("a");
queue1.Dequeue();

foreach (var item in queue1.ToArray())
{
    System.Console.WriteLine(item);
}

Queue<int> queue = new Queue<int>(4);
queue.Enqueue(1);
Console.WriteLine(queue.ToString());
queue.Enqueue(2);
Console.WriteLine(queue.ToString());
queue.Enqueue(3);
Console.WriteLine(queue.ToString());
queue.Dequeue();
queue.Enqueue(4);
Console.WriteLine(queue.ToString());
queue.Dequeue();
Console.WriteLine(queue.ToString());
queue.Dequeue();
Console.WriteLine(queue.ToString());
queue.Dequeue();
Console.WriteLine(queue.ToString());

public class Queue<T>(int max)
{
    private readonly int _max = max;
    private readonly List<T> _queue = new List<T>(max);

    public void Enqueue(T item)
    {
        if (_queue.Count > _max)
        {
            throw new InvalidOperationException("Queue overflow");
        }
        else
        {
            _queue.Add(item);
        }
    }

    public T Dequeue()
    {
        if (_queue.Count <= 0)
        {
            throw new InvalidOperationException("Queue underflow");
        }
        T item = _queue.First();
        _queue.RemoveAt(0);
        return item;
    }

    public override string ToString()
    {
        string str = "";
        _queue.ForEach(x => str += x.ToString());
        // foreach (var item in _queue)
        // {
        //     str += item + " ";
        // }
        // for (int i = 0; i < _queue.Count; i++)
        // {
        //     str += _queue[i] + " ";
        // }
        return str;
    }
}