namespace MyDataStructureLibrary;

public class StackList<T> : MyLinkedList<T> where T : IComparable
{
    public static StackList<T> Stack()
    {
        return new StackList<T>();
    }

    /// <summary>
    /// Pushes the specified data to stack
    /// </summary>
    /// <param name="data">The data.</param>
    public void Push(T data)
    {
        Add(data);
    }
    public T Peek()
    {
        return head.data;
    }

    public new void Pop()
    {
        base.Pop();
    }
}