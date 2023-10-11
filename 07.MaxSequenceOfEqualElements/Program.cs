namespace _07.MaxSequenceOfEqualElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] array = Console.ReadLine()
                .Split();

            int newBestCount = 0;
            string bestCountSymbols = "";

            for (int i = 0; i < array.Length - 1; i++)
            {
                int count = 1;

                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] == array[j])
                    {
                        count++;
                        if (count > newBestCount)
                        {
                            newBestCount = count;
                            bestCountSymbols = array[i] + " ";
                        }
                    }
                    else
                    {
                        break;
                    }
                }
            }

            for (int i = 0; i < newBestCount; i++)
            {
                Console.Write(bestCountSymbols);
            }
        }
    }
}
