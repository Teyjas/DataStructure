namespace MyDataStructureLibrary;

public class Node<T> where T : IComparable
{
    public T data;
    public Node<T> next;

    public Node(T data) => this.data = data;
}
