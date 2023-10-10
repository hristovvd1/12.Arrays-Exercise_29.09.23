namespace _06.EqualSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] elemenets = Console.ReadLine() // 1 2 3 3
                .Split()
                .Select(int.Parse)
                .ToArray();

            int index = -1;

            for (int i = 0; i < elemenets.Length; i++)
            {
                index = -1;
                int sumRight = 0;
                int sumLeft = 0;
                int[] elements2 = elemenets;

                for (int j = i + 1; j < elemenets.Length; j++)
                {
                    sumRight += elements2[j];
                }

                for (int j = i - 1; j >= 0; j--)
                {
                    sumLeft += elements2[j];
                }

                if (sumRight == sumLeft)
                {
                    index = i;
                    break;
                }
            }

            if (index != -1)
            {
                Console.WriteLine(index);
            }

            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
