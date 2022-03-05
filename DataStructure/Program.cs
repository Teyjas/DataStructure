﻿namespace MyDataStructureLibrary;

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

