namespace Algs.Sorting;

public class Sort
{
    private static void Swap(ref int a, ref int b)
    {
        var temp = a;
        a = b;
        b = temp;
    }
    
    // Пузырьковая сортировка
    // O(n^2)
    public static int[] BubbleSort(int[] arr)
    {
        var len = arr.Length;

        for (int i = 1; i < len; i++)
        {
            for (int j = 0; j < len - i; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    Swap(ref arr[j], ref arr[j + 1]);
                }
            }
        }

        return arr;
    }
    
    // Сортировка выбором
    // O(n^2)
    public static int[] SelectionSort(int[] arr)
    {
        for (int i = 0; i < arr.Length - 1; i++)
        {
            var minIndex = i;
            for (int j = i + 1; j < arr.Length; j++)
            {
                if (arr[j] < arr[minIndex])
                {
                    minIndex = j;
                }
            }
            
            Swap(ref arr[i], ref arr[minIndex]);
        }

        return arr;
    }
    
    // Сортировка вставками
    // O(n^2)
    public static int[] InsertionSort(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            int j = i;
            while (j != 0)
            {
                if (arr[j] < arr[j - 1])
                {
                    Swap(ref arr[j], ref arr[j - 1]);
                }
                j--;
            }
        }

        return arr;
    }
    
    
}