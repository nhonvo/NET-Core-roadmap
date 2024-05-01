LinkedList linkedList = new();
linkedList.Add(1);
linkedList.Add(2);
linkedList.Add(3);
Console.WriteLine(linkedList.ToString());
linkedList.Remove(3);
Console.WriteLine(linkedList.ToString());


public class Node(int data)
{
    public int Data { get; set; } = data;
    public Node Next { get; set; }
}

public class LinkedList
{
    private Node _head;
    public void Add(int data)
    {
        Node newNode = new Node(data);
        if (_head == null)
        {
            _head = newNode;
        }
        else
        {
            Node current = _head;
            while (current.Next != null)
            {
                current = current.Next;
            }
            current.Next = newNode;
        }
    }

    public void Remove(int data)
    {
        Node current = _head;
        Node? previous = null;
        while (current != null)
        {
            if (current.Data == data)
            {
                if (previous == null)
                {
                    _head = current.Next;
                }
                else
                {
                    previous.Next = current.Next;
                }
                break;
            }
            previous = current;
            current = current.Next;
        }
    }

    public override string ToString()
    {
        Console.WriteLine("Linked List Elements:");
        Node current = _head;
        string result = "";
        while (current != null)
        {
            result += $"{current.Data} -> ";
            current = current.Next;
        }
        return result + "NULL";
    }
}