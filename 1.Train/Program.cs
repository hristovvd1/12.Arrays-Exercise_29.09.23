namespace _1.Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int wagons = int.Parse(Console.ReadLine());

            int[] arrayWagons = new int[wagons];
            int totalPeople = 0;

            for (int i = 0; i < wagons; i++)
            {
                int people = int.Parse(Console.ReadLine());

                arrayWagons[i] = people;
                totalPeople+=people;
            }
            Console.WriteLine(string.Join(" ", arrayWagons));
            Console.WriteLine(totalPeople);
        }
    }
}
