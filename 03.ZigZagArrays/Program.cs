namespace _03.ZigZagArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());

            int[] arr1 = new int[lines];
            int[] arr2 = new int[lines];

            for (int i = 0; i < lines; i++)
            {
                int[] nextLines = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

                if (i % 2 == 0)
                {
                    arr1[i] = nextLines[0];
                    arr2[i] = nextLines[1];
                }

                else
                {
                    arr1[i] = nextLines[1];
                    arr2[i] = nextLines[0];
                }
            }

            Console.WriteLine(string.Join(" ", arr1));
            Console.WriteLine(string.Join(" ", arr2));

        }
    }
}
