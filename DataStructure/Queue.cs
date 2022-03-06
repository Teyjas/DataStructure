﻿namespace MyDataStructureLibrary;

/// <summary>
/// Handles Queue operations
/// </summary>
public class QueueList<T> : LinkedList<T> where T : IComparable
{
    /// <summary>
    /// return empty queue
    /// </summary>
    /// <returns></returns>
    public static QueueList<T> Queue()
    {
        return new QueueList<T>();
    }

    /// <summary>
    /// Enqueues the specified data.
    /// </summary>
    /// <param name="data">The data.</param>
    public void Enqueue(T data)
    {
        Append(data);
    }

    /// <summary>
    /// Deletes first element in queue.
    /// </summary>
    public void Dequeue()
    {
        base.Pop();
    }
}