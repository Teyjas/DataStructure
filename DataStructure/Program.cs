namespace MyDataStructureLibrary;


/// <summary>
/// This is the base abstract class for all generic data structure lists
/// </summary>
public abstract class MyLinkedList<T> where T : IComparable
{
    // Declared Node Object
    protected Node<T> head;

    /// <summary>
    /// Initializes a new instance of the <see cref="UnOrderedLinkedList{T}"/> class.
    /// </summary>
    public MyLinkedList()
    {
        head = null;
    }

    /// <summary>
    /// Determines whether the list is empty.
    /// </summary>
    /// <returns>
    ///   <c>true</c> if this instance is empty; otherwise, <c>false</c>.
    /// </returns>

    public bool IsEmpty()
    {
        if (head == null)
            return true;
        return false;
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
    public void Insert(int pos, T data)
    {
        Node<T> temp = head;
        if (pos < 0)
        {
            Console.WriteLine("Invalid position");
            return;
        }
        if (pos == 0)
            Add(data);
        else
        {
            Node<T> node = new Node<T>(data);
            for (int i = 1; i < pos; i++)
                temp = temp.next;
            node.next = temp.next;
            temp.next = node;
        }
    }
    public void Pop()
    {
        if (head == null)
            return;
        else
            head = head.next;
    }
    public void PopLast()
    {
        if (head == null)
            return;
        else
        {
            Node<T> temp = head;
            while (temp.next.next != null)
                temp = temp.next;
            temp.next = null;
        }
    }
    public bool Search(T data)
    {
        Node<T> temp = head;
        while (temp != null)
        {
            if (temp.data.CompareTo(data) == 0)
                return true;
            temp = temp.next;
        }
        return false;
    }

    public int Index(T data)
    {
        int index = 0;
        Node<T> temp = head;
        while (temp != null)
        {
            if (temp.data.CompareTo(data) == 0)
                return index;
            temp = temp.next;
            index++;
        }
        return -1;
    }
    public void Remove(T data)
    {
        if (IsEmpty())
            return;
        if (head.data.CompareTo(data) == 0)
            head = head.next;
        else
        {
            Node<T> temp = head;
            while (temp != null)
            {
                if (temp.next.data.CompareTo(data) == 0)
                {
                    temp.next = temp.next.next;
                    return;
                }
                temp = temp.next;
            }
        }
    }

    /// <summary>
    /// Returns the size of the list(No of elements in list)
    /// </summary>
    /// <returns></returns>
    public int Size()
    {
        int size = 0;
        Node<T> temp = head;
        while (temp != null)
        {
            size++;
            temp = temp.next;
        }
        return size;
    }
}

