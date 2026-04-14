using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] genres = { "RPG", "Shooter", "Action", "Sandbox" };
            var (gamesByGenre, counts) = Input.InputGamesByGenre();
            string userQuery = Input.InputUserQuery();
            int indexGenre = Search.FindIndexGenre(userQuery, genres);

            if (indexGenre == -1)
            {
                Console.WriteLine("Жанр не найден!");
                return;
            }

            var (games, genreCounts) = Search.FindAllGamesByGenre(indexGenre, gamesByGenre, counts);
            Analysis.SortGames(games, genreCounts);
            Console.WriteLine($"\nИгры в жанре {genres[indexGenre]} (отсортированы по популярности):");
            Program.Print(games);
            Console.WriteLine($"\nКоличество скачиваний для жанра {genres[indexGenre]}:");
            Program.PrintCounts(genreCounts.Select(x => x.ToString()).ToList());
            double average = Analysis.CalculateAverage(genreCounts);
            Console.WriteLine($"\nСреднее количество скачиваний: {average:F0}");
        }
        static public void Print(List<string> games) // вывод списка игр
        {
            Console.WriteLine("Список игр: ");
            for (int i = 0; i < games.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {games[i]}");
            }
        }
        static public void PrintCounts(List<string> counts) // вывод количества скачиваний
        {
            Console.WriteLine("Количество скачиваний: ");
            for (int i = 0; i < counts.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {counts[i]}");
            }
        }

    }
}
