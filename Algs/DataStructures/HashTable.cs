namespace Algs.DataStructures;

public class HashTable<TKey, TValue>
{
    private class HashNode
    {
        public TKey Key;
        public TValue Value;
        public HashCode Next;

        public HashNode(TKey key, TValue value)
        {
            Key = key;
            Value = value;
        }
    }

    private List<HashNode>[] buckets;

    public HashTable(int size)
    {
        buckets = new List<HashNode>[size];
        for (int i = 0; i < buckets.Length; i++)
        {
            buckets[i] = new List<HashNode>();
        }
    }

    public int GetBucketIndex(TKey key)
    {
        var hashCode = Math.Abs(key.GetHashCode());
        return hashCode % buckets.Length;
    }

    public void Add(TKey key, TValue value)
    {
        var index = GetBucketIndex(key);
        var hashNode = new HashNode(key, value);

        var head = buckets[index].Find(b => b.Equals(key));
        
        if (head != null)
        {
            throw new ArgumentException("Key already exists.");
        }
        buckets[index].Add(hashNode);
    }
    
    public bool TryGetValue(TKey key, out TValue value)
    {
        int bucketIndex = GetBucketIndex(key);
        HashNode head = buckets[bucketIndex].Find(n => n.Key.Equals(key));

        if (head != null)
        {
            value = head.Value;
            return true;
        }

        value = default(TValue);
        return false;
    }
}