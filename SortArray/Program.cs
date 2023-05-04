namespace SortArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var array = new int[5];

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"Напишите целое число");
                array[i] = int.Parse(Console.ReadLine());
            }

            SortArray(in array, out int[] sortedask, out int[] sorteddesk);
        }

        static void SortArray(in int[] array, out int[] sortedask, out int[] sorteddesk)
        {
            sortedask = SortArrayAsk(array);
            sorteddesk = SortArrayDesk(array);
        }

        static int[] SortArrayAsk(int[] array)
        {

            int vrem = 0;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        vrem = array[i];
                        array[i] = array[j];
                        array[j] = vrem;
                    }
                }
            }
            Console.WriteLine("Числа по возрастанию:");
            foreach (int num in array)
            {
                Console.WriteLine(num);
            }

            return array;
        }

        static int[] SortArrayDesk(int[] array)
        {

            int vrem = 0;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] < array[j])
                    {
                        vrem = array[i];
                        array[i] = array[j];
                        array[j] = vrem;
                    }
                }
            }
            Console.WriteLine("Числа по убыванию:");
            foreach (int num in array)
            {
                Console.WriteLine(num);
            }

            return array;
        }
    }
}