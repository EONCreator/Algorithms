using System.Collections;

namespace Algs.DataStructures;

public class LinkedList<T> : IEnumerable<T>
{
    private class Node<TData>
    {
        public TData Data { get; set; }
        public Node<T> Next { get; set; }

        public Node(TData data)
        {
            Data = data;
        }
    }

    private Node<T>? head;
    private Node<T>? tail;

    private int count = 0;

    public void Add(T data)
    {
        Node<T> node = new Node<T>(data);
        
        if (head == null)
            head = node;
        else
            tail!.Next = node;
        
        tail = node;
        count++;
    }
    
    IEnumerator<T> IEnumerable<T>.GetEnumerator()
    {
        Node<T>? current = head;
        while (current != null)
        {
            yield return current.Data;
            current = current.Next;
        }
    }
 
    // реализация интерфейса IEnumerable
    IEnumerator IEnumerable.GetEnumerator()
    {
        return ((IEnumerable<T>)this).GetEnumerator();
    }
}