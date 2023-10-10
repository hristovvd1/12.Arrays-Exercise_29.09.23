namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long fieldLength = int.Parse(Console.ReadLine()); // число дължината на полето
            int[] bugPlaces = Console.ReadLine() // масив от n на брой калинки
                .Split()
                .Select(int.Parse)
                .ToArray();

            long[] field = new long[fieldLength]; // масив от числото с дължината на полето

            for (int i = 0; i < bugPlaces.Length; i++) // въртим цикъл с дължина n на брой калинки (масива в началото)
            {
                int bugIndex = bugPlaces[i]; // int променлива, в коя клетка на масива с n на брой калинки сме в момента
                if (bugIndex >= 0 && bugIndex < field.Length) // проверка, дали сме вътре в главния масив (полето)
                {
                    field[bugIndex] = 1; // докато сме вътре в полето слагаме калинките в съответните клетки на главния масив (полето)
                }
            }

            string command = string.Empty; // празен стринг

            while ((command = Console.ReadLine()) != "end") // докато тази команда е различна от end, влизаме в while цикъла
            {
                string[] elements = command.Split(); // правим стринг масив и го сплитваме, винаги е от 3 клетки с команди
                int bugIndex = int.Parse(elements[0]); // инт променлива, която парсва командата от първата клетка на стринг масива т.е клетка 0
                string direction = elements[1]; // стринг променлива, която парсва командата от втората клетка на стринг масива т.е клетка 1
                int flyLength = int.Parse(elements[2]); // инт променлива, която парсва командата от третата клетка на стринг масива т.е клетка 2

                if (bugIndex < 0 || bugIndex > field.Length || field[bugIndex] == 0) // проверяваме обратното на първия случай, дали сме извън главния масив, не дали сме вътре в него и дали командата е 0. Ако е нула
                                                                                     // не правими нищо и продължаваме да въртим цикъла.
                {
                    continue;
                }

                field[bugIndex] = 0; // в тази клетка е имало калинка и тя отлита, затова клетката става 0

                if (direction == "right") // if ако посоката на летене е надясно
                {
                    int landIndex = bugIndex + flyLength; // правим инт променлива landindex, равна на клетката, от където е отлятяла калинката + дължината на летене т.е. 0 + n

                    if (landIndex > field.Length) // друга проверка, ако landindex е повече от дължината на главния масив, въртим цикъла отново
                    {
                        continue;
                    }

                    if (field[landIndex] == 1) // if проверка, ако в дадената клетка от главния масив (полето), където трябва да кацне калинката, вече има калинка.
                    {
                        while (field[landIndex] == 1) // въртим нов while цикъл, докато в полето има калинка
                        {
                            landIndex += flyLength; // взимаме отново инт променливата, равна на клетката, от където е отлятяла калинката + дължината на летене т.е. 0 + n и добавяме дължината на летене и въртим цикъла
                            if (landIndex > field.Length) // if проверяваме, дали не се излезли от дясно на полето. Ако сме надвишили break-ваме
                            {
                                break;
                            }
                        }
                    }

                    if (landIndex <= field.Length) // if ако не сме надвишили и сме вътре в полето
                    {
                        field[landIndex] = 1; // щом сме тук, значи мястото в полето е празно и каза калинката т.е. става 1ца клетката
                    }
                }
                else if (direction == "left")
                {
                    int landIndex = bugIndex - flyLength;

                    if (landIndex < 0)
                    {
                        continue;
                    }

                    if (field[landIndex] == 1)
                    {
                        while (field[landIndex] == 1)
                        {
                            landIndex -= flyLength;
                            if (landIndex < 0)
                            {
                                break;
                            }
                        }
                    }

                    if (landIndex >= 0)
                    {
                        field[landIndex] = 1;
                    }
                }
            }

            Console.WriteLine(string.Join(" ", field));
        }
    }
}
