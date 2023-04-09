namespace ConsoleApp5._2._18   // Так же это можно отнести к решению задания 5.3.13.
{
    internal class Program
    {

        static int[] arr = new int[10] { 1, 2, -3, -4, 5, -6, 7, 8, 9, 112 };

        static void Main(string[] args)
        {
            var resultUp = SortArray(arr);
            ShowArray(resultUp);

            var resultDown = SortArray(arr, true);
            ShowArray(resultDown);
        }

        static int[] SortArray(int[] result, bool isSortedUp = false)
        {
            for (int i = 0; i < result.Length; i++)
            {
                for (int j = i + 1; j < result.Length; j++)
                {
                    if (isSortedUp)
                    {
                        if (result[i] > result[j])
                        {
                            int temp = result[i];
                            result[i] = result[j];
                            result[j] = temp;
                        }
                    }
                    else
                    {
                        if (result[i] < result[j])
                        {
                            int temp = result[i];
                            result[i] = result[j];
                            result[j] = temp;
                        }
                    }
                }
            }
            return result;
        }

        static void ShowArray(int[] array)
        {
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
        }
    }
}
