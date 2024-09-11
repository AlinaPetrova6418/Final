class Program
{
    static void Main(string[] args)
    {
        string[] array1 = new string[6] { "Mother", "356", "You", "-8", "Lu", "21" };
        string[] array2 = new string[array1.Length];

        ComparisonArray(array1, array2);
        PrintArray(array2);
    }