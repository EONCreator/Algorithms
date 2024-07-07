using System.Collections;

namespace Algs.DataStructures;

public class DoublyLinkedList<T> : IEnumerable<T>
{
    private class DoublyNode<TData>
    {
        public TData Data { get; set; }
        
        public DoublyNode<TData>? Previous { get; set; }
        public DoublyNode<TData>? Next { get; set; }

        public DoublyNode(TData data)
        {
            Data = data;
        }
    }

    private DoublyNode<T> head;
    private DoublyNode<T> tail;
    private int count;

    public void Add(T data)
    {
        var node = new DoublyNode<T>(data);

        if (head == null)
            head = node;
        else
        {
            tail!.Next = node;
            node.Previous = tail;
        }

        tail = node;
        count++;
    }

    public void Remove(T data)
    {
        
    }
    
    IEnumerator IEnumerable.GetEnumerator()
    {
        return ((IEnumerable)this).GetEnumerator();
    }
    
    IEnumerator<T> IEnumerable<T>.GetEnumerator()
    {
        DoublyNode<T> current = head;
        while (current != null)
        {
            yield return current.Data;
            current = current.Next;
        }
    }
 
    public IEnumerable<T> BackEnumerator()
    {
        DoublyNode<T> current = tail;
        while (current != null)
        {
            yield return current.Data;
            current = current.Previous;
        }
    }
}