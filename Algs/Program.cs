using Algs.DataStructures;
using Algs.Sorting;

class Program
{
    public static void Main()
    {
        /*HashTable<string, int> hashTable = new HashTable<string, int>(100);
        hashTable.Add("three", 3);
        hashTable.Add("seven", 7);
        hashTable.Add("twenty", 20);
        
        if (hashTable.TryGetValue("twenty", out int value))
        {
            Console.WriteLine("Значение элемента: " + value);
        }
        else
        {
            Console.WriteLine("Элемент не найден.");
        }*/

        /*Algs.DataStructures.LinkedList<int> list = new Algs.DataStructures.LinkedList<int>();
        list.Add(7);
        list.Add(10);
        list.Add(14);
        list.Add(20);
        list.Add(58);

        foreach (var item in list)
        {
            Console.WriteLine(item);
        }*/

        Sort sort = new Sort();
        var arr = new int[] { 3, 8, 5, 9, 1, 3 };
        foreach (var item in arr)
        {
            Console.WriteLine(item);
        }

        //Sort.BubbleSort(arr);
        //Sort.SelectionSort(arr);
        Sort.InsertionSort(arr);
        
        Console.WriteLine("Sorted:");
        foreach (var item in arr)
        {
            Console.WriteLine(item);
        }
    }
}