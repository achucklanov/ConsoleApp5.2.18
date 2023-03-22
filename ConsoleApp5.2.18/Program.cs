namespace ConsoleApp5._2._18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GetArrayFromConsole();
        }

        static int[] GetArrayFromConsole()
        {
            var result = new int[10];

            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine("Введите элемент массива номер {0}", i + 1);
                result[i] = int.Parse(Console.ReadLine());
            }

            return result;
        }

        static int[] SortArray(int[] result)
        {

            int temp = 0;

            for (int i = 0; i < result.Length; i++)
            {
                for (int j = i + 1; j < result.Length; j++)
                {
                    if (result[i] > result[j])
                    {
                        temp = result[i];
                        result[i] = result[j];
                        result[j] = temp;
                    }
                }
            }
            return result;

            static void ShowArray(int[] array, bool IsSort = false)
            {
                var temp = array;

                if (IsSort)
                {
                    temp = SortArray(array);
                }
                foreach (var item in temp)
                {
                    Console.WriteLine(item);
                }

                var array = GetArrayFromConsole(10);
                ShowArray(array, true);
            }
        }
    }
}