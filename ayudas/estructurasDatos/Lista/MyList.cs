using System;
public class MyNode<T>
{
    public T Value { get; set; }
    public MyNode<T> Next { get; set; }
    public MyNode(T value)
    {
        Value = value;
        Next = null;
    }
}
public class List<T> where T : IComparable<T>
{
    private MyNode<T> head;
    public List()
    {
        head = null;
    }
    public MyNode<T> Push(T value)
    {
        var node = new MyNode<T>(value);

        if (head == null)
        {
            head = node;
        }
        else
        {
            var headAux = head;
            while (headAux.Next != null)
            {
                headAux = headAux.Next;
            }
            headAux.Next = node;
        }

        return node;
    }

    public T Pop()
    {
        if (head == null) return default;

        MyNode<T> headAux = head;
        MyNode<T> previus = null;

        while (headAux.Next != null)
        {
            previus = headAux;
            headAux = headAux.Next;
        }

        if (previus == null)
        {
            head = null;
        }
        else
        {
            previus.Next = null;
        }

        return headAux.Value;
    }

    public MyNode<T> InsertFirst(T value)
    {
        var node = new MyNode<T>(value);
        node.Next = head;
        head = node;
        return node;
    }
    public T RemoveFirst()
    {
        if (head == null) return default;
        T value = head.Value;
        head = head.Next;
        return value;
    }
    public MyNode<T> InsertOrdered(T value)
    {
        var node = new MyNode<T>(value);
        MyNode<T> headAux = head;
        MyNode<T> previous = null;
        while (headAux != null && headAux.Value.CompareTo(value) < 0)
        {
            previous = headAux;
            headAux = headAux.Next;
        }
        if (previous == null)
        {
            head = node;
        }
        else
        {
            previous.Next = node;
        }
        node.Next = headAux;
        return node;
    }
    public MyNode<T> InsertUnique(T value)
    {
        var node = Search(value);
        if (node == null)
        {
            return InsertOrdered(value);
        }
        return node;
    }
    public T Delete(T value)
    {
        MyNode<T> headAux = head;
        MyNode<T> previous = null;
        while (headAux != null && !headAux.Value.Equals(value))
        {
            previous = headAux;
            headAux = headAux.Next;
        }
        if (headAux == null) return default;
        if (previous == null)
        {
            head = headAux.Next;
        }
        else
        {
            previous.Next = headAux.Next;
        }
        return headAux.Value;
    }
    public MyNode<T> Search(T value)
    {
        MyNode<T> headAux = head;
        while (headAux != null && !headAux.Value.Equals(value))
        {
            headAux = headAux.Next;
        }
        return headAux;
    }
    public void Sort()
    {
        var listAux = new List<T>();
        while (head != null)
        {
            T value = RemoveFirst();
            listAux.InsertOrdered(value);
        }
        head = listAux.head;
        listAux.Clear();
    }
    public void Clear()
    {
        while (head != null)
        {
            RemoveFirst();
        }
    }
}
