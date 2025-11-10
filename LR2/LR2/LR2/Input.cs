using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR2 // Кувалдаев П-30 Вариант 5
{
    public class Input
    {
        static public (List<string>[], List<int>[]) InputGamesByGenre() // данные о играх
        {
            List<string>[] gamesByGenre = new List<string>[4] {
            new List<string>(), // RPG
            new List<string>(), // Shooter
            new List<string>(), // Action
            new List<string>()  // Sandbox
            };
            List<int>[] counts = new List<int>[4] {
            new List<int>(), // RPG
            new List<int>(), // Shooter
            new List<int>(), // Action
            new List<int>()  // Sandbox
            };

            gamesByGenre[0].Add("The Witcher 3: Wild Hunt"); // RPG
            counts[0].Add(1500000);
            gamesByGenre[0].Add("Cyberpunk 2077");
            counts[0].Add(1200000);
            gamesByGenre[0].Add("Skyrim");
            counts[0].Add(1800000);
            gamesByGenre[0].Add("Dark Souls III");
            counts[0].Add(900000);

            gamesByGenre[1].Add("Call of Duty: Modern Warfare"); // Shooter
            counts[1].Add(2000000);
            gamesByGenre[1].Add("Counter-Strike 2");
            counts[1].Add(2500000);
            gamesByGenre[1].Add("DOOM Eternal");
            counts[1].Add(800000);
            gamesByGenre[1].Add("Battlefield 2042");
            counts[1].Add(600000);

            gamesByGenre[2].Add("Grand Theft Auto V"); // Action
            counts[2].Add(3000000);
            gamesByGenre[2].Add("Red Dead Redemption 2");
            counts[2].Add(1600000);
            gamesByGenre[2].Add("God of War");
            counts[2].Add(1400000);
            gamesByGenre[2].Add("Assassin's Creed Valhalla");
            counts[2].Add(1100000);

            gamesByGenre[3].Add("Minecraft"); // Sandbox
            counts[3].Add(4000000);
            gamesByGenre[3].Add("Terraria");
            counts[3].Add(700000);
            gamesByGenre[3].Add("Roblox");
            counts[3].Add(3500000);
            gamesByGenre[3].Add("Garry's Mod");
            counts[3].Add(500000);

            return (gamesByGenre, counts);
        }
        static public string InputUserQuery() // запрос жанра у пользователя
        {
            Console.Write("Введите жанр игр (RPG, Shooter, Action или Sandbox): ");
            return Console.ReadLine();
        }
    }
}
