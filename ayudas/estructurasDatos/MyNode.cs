public class MyNode<T>
{
    private T _value;
    private MyNode<T>? _next;
    public MyNode(T value)
    {
        _value = value;
        _next = null;
    }
    public T Value
    {
        get { return _value; }
    }
    public MyNode<T>? Next
    {
        get { return _next; }
    }
}