namespace Demo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long fieldLength = int.Parse(Console.ReadLine());
            int[] kletkiKudetoPostavqmeKalinki = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            long[] field = new long[fieldLength];

            for (int i = 0; i < kletkiKudetoPostavqmeKalinki.Length; i++)
            {
                int currentIndex = kletkiKudetoPostavqmeKalinki[i];

                if (currentIndex >= 0 && currentIndex < field.Length)
                {
                    field[currentIndex] = 1;
                }
            }

            string command = "";

            while ((command = Console.ReadLine()) != "end")
            {
                string[] elements = command
                    .Split()
                    .ToArray(); // може и без това, защо?

                int kletkaOtKoqtoIzlitaKalinkata = int.Parse(elements[0]);
                string direction = elements[1];
                int flyLength = int.Parse(elements[2]);

                if (kletkaOtKoqtoIzlitaKalinkata < 0 || kletkaOtKoqtoIzlitaKalinkata > field.Length - 1 || field[kletkaOtKoqtoIzlitaKalinkata] == 0)
                {
                    continue;
                }

                field[kletkaOtKoqtoIzlitaKalinkata] = 0;

                if (direction == "right")
                {
                    int KletkaKudeKacaKalinkata = kletkaOtKoqtoIzlitaKalinkata + flyLength;

                    if (KletkaKudeKacaKalinkata > field.Length - 1)
                    {
                        continue;

                    }

                    if (field[KletkaKudeKacaKalinkata] == 1)
                    {
                        while (field[KletkaKudeKacaKalinkata] == 1)
                        {
                            KletkaKudeKacaKalinkata += flyLength;

                            if (KletkaKudeKacaKalinkata > field.Length - 1)
                            {
                                break;
                            }
                        }
                    }

                    if (KletkaKudeKacaKalinkata <= field.Length - 1)
                    {
                        field[KletkaKudeKacaKalinkata] = 1;
                    }
                }

                else if (direction == "left")
                {
                    int KletkaKudeKacaKalinkata = kletkaOtKoqtoIzlitaKalinkata - flyLength;

                    if (KletkaKudeKacaKalinkata < 0)
                    {
                        continue;
                    }

                    if (field[KletkaKudeKacaKalinkata] == 1)
                    {
                        while (field[KletkaKudeKacaKalinkata] == 1)
                        {
                            KletkaKudeKacaKalinkata -= flyLength;

                            if (KletkaKudeKacaKalinkata < 0)
                            {
                                break;
                            }
                        }
                    }

                    if (KletkaKudeKacaKalinkata >= 0)
                    {
                        field[KletkaKudeKacaKalinkata] = 1;
                    }
                }
            }

            Console.WriteLine(string.Join(" ", field));
        }
    }
}
