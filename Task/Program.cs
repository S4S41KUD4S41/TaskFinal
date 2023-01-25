internal class Program
{
    private static void Main(string[] args)
    {
        var array1 = new string[5] { "none", "1", "2", "unknown", "3" };
        string[] array2 = new string[array1.Length];
        void InputNewArray(string[] array1, string[] array2)
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
        void Print(string[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }
            Console.WriteLine();
        }
        InputNewArray(array1, array2);
        Print(array2);
    }
}