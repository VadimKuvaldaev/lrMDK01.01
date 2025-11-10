using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR2
{
    public class Analysis
    {
        static public void SortGames(List<string> games, List<int> counts) // Сортировка игр по количеству скачиваний
        {
            for (int i = 0; i < counts.Count; i++)
            {
                for (int j = 0; j < counts.Count - 1; j++)
                {
                    bool condition = counts[j + 1] > counts[j];
                    if (condition)
                    {
                        int temp_counts = counts[j];
                        counts[j] = counts[j + 1];
                        counts[j + 1] = temp_counts;
                        string temp_books = games[j];
                        games[j] = games[j + 1];
                        games[j + 1] = temp_books;
                    }
                }
            }
        }
    }
}
