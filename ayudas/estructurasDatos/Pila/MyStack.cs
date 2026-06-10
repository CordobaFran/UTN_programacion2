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
public class Stack<T>
{
    private MyNode<T> head;
    public Stack()
    {
        head = null;
    }
    public void Push(T value)
    {
        var newNode = new MyNode<T>(value);
        newNode.Next = head;
        head = newNode;
    }
    public T Pop()
    {
        if (IsEmpty())
        {
            return default; // devuelve null para referencias o valor por defecto para tipos primitivos
        }
        T value = head.Value;
        head = head.Next;
        return value;
    }
    public bool IsEmpty()
    {
        return head == null;
    }
}
