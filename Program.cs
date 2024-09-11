class Program
{
    static void Main(string[] args)
    {
        string[] array1 = new string[6] { "Mother", "356", "You", "-8", "Lu", "21" };
        string[] array2 = new string[array1.Length];

        ComparisonArray(array1, array2);
        PrintArray(array2);
    }
    static void ComparisonArray(string[] array1, string[] array2)
    {
        int count = 0;
        for (int i = 0; i < array1.Length; i++)
        {
            if (array1[i].Length <= 3)
            {
                array2[count] = array1[i];
                count++;
            }
        }
    }

    static void PrintArray(string[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] != null)
            {
                Console.Write($"{array[i]} ");
            }
        }
        Console.WriteLine();
    }
}