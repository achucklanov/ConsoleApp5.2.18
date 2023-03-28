namespace ConsoleApp5._2._18   // Так же это можно отнести к решению задания 5.3.13.
{
    internal class Program
    {

        static int[] arr = new int[10] { 1, 2, -3, -4, 5, -6, 7, 8, 9, 112 };
        static void Main(string[] args)
        {
            var resultUp = SortArray(arr, false);
            var resultDown = SortArray(arr, true);

            ShowArray(resultDown);
            ShowArray(resultUp);

            //   GetArrayFromConsole();
        }

        //static int[] GetArrayFromConsole()
        //{
        //    var result = new int[10];

        //    for (int i = 0; i < result.Length; i++)
        //    {
        //        Console.WriteLine("Введите элемент массива номер {0}", i + 1);
        //        result[i] = int.Parse(Console.ReadLine());
        //    }

        //    return result;
        //}

        static int[] SortArray(int[] result, bool isSortedUp)
        {

            int temp = 0;

            for (int i = 0; i < result.Length; i++)
            {
                for (int j = i + 1; j < result.Length; j++)
                {
                    if (isSortedUp)
                    {
                        if (result[i] > result[j])

                        {
                            temp = result[i];
                            result[i] = result[j];
                            result[j] = temp;
                        }

                    }
                    else
                    {
                        if (result[i] < result[j])
                        {
                            temp = result[i];
                            result[i] = result[j];
                            result[j] = temp;
                        }
                    }
                }

            }
            return result;
        }

        static void ShowArray(int[] array, bool IsSort = false)
        {

            //var result = new int[10];

            //if (IsSort)
            //{
            //result = SortArray(arr);
            //}
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }


            //ShowArray(result, true);
        }
    }
}
