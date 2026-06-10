using System;
public class MyNode<T>
{
    public T Value { get; }
    public MyNode<T> Next { get; set; }
    public MyNode(T value)
    {
        Value = value;
        Next = null;
    }
}
public class Queue<T>
{
    private MyNode<T> first;
    private MyNode<T> last;
    public Queue()
    {
        first = null;
        last = null;
    }
    public void Enqueue(T value)
    {
        var newNode = new MyNode<T>(value);
        if (IsEmpty())
        {
            first = newNode;
        }
        else
        {
            last.Next = newNode;
        }
        last = newNode;
    }
    public T Dequeue()
    {
        if (IsEmpty())
        {
            return default; // null para referencias, valor por defecto para tipos primitivos
        }
        T value = first.Value;
        first = first.Next;
        if (first == null)
        {
            last = null;
        }
        return value;
    }
    public bool IsEmpty()
    {
        return first == null && last == null;
    }
}

