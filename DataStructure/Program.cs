namespace MyDataStructureLibrary;

public class UnOrderedLinkedList<T> where T : IComparable<T>
{
    public Node<T> head;


    public UnOrderedLinkedList()

    {
        head = null;
    }
    public UnOrderedLinkedList<T> List()
    {
        UnOrderedLinkedList<T> emptyList = new UnOrderedLinkedList<T>();
        return emptyList;
    }

    public void Append(T data)
    {
        Node<T> node = new Node<T>(data);
        if (head == null)
            head = node;
        else
        {
            Node<T> temp = head;
            while (temp.next != null)
                temp = temp.next;
            temp.next = node;
        }
    }

    public void Display()
    {
        Node<T> temp = head;
        while (temp != null)
        {
            Console.Write("\n" + temp.data);
            temp = temp.next;
        }
    }
    public void Add(T data)
    {
        Node<T> node = new Node<T>(data);
        if (head == null)
            head = node;
        else
        {
            node.next = head;
            head = node;
        }

    }
}
