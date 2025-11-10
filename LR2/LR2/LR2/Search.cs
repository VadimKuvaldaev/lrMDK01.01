using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR2
{
    public class Search
    {
        static public int FindIndexGenre(string userQuery, string[] genres) 
        {
            for (int index = 0; index < genres.Length; ++index) 
            { 
              string valueGenre = genres[index].ToLower();
                if (valueGenre == userQuery.ToLower()) 
                {
                  return index;
                }
            }
            return -1;
        }
        static public (List<string>, List<int>) FindAllGamesByGenre(int indexGenre, 
                                                                     List<string>[] allGames, 
                                                                     List<int>[] counts)
        {

        }
    }
}
