using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR2 // Кувалдаев П-30 Вариант 5
{
    internal class Program
    {
        static public void Main(string[] args)
        {
            string[] genres = { "RPG", "Shooter", "Action", "Sandbox" };

            // Получаем данные об играх
            var (gamesByGenre, counts) = Input.InputGamesByGenre();

            // Запрашиваем жанр у пользователя
            string userQuery = Input.InputUserQuery();

            // Ищем индекс жанра
            int indexGenre = Search.FindIndexGenre(userQuery, genres);

            if (indexGenre == -1)
            {
                Console.WriteLine("Жанр не найден!");
                return;
            }

            // Получаем игры выбранного жанра
            var (games, genreCounts) = Search.FindAllGamesByGenre(indexGenre, gamesByGenre, counts);

            // Сортируем игры по количеству скачиваний
            Analysis.SortGames(games, genreCounts);

            // Выводим отсортированный список игр
            Console.WriteLine($"\nИгры в жанре {genres[indexGenre]} (отсортированы по популярности):");
            Program.Print(games);

            // Выводим количество скачиваний
            Console.WriteLine($"\nКоличество скачиваний для жанра {genres[indexGenre]}:");
            Program.PrintCounts(genreCounts.Select(x => x.ToString()).ToList());

            // Выводим среднее количество скачиваний
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
