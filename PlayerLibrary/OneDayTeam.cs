using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerLibrary
{
    public class OneDayTeam : ITeam
    {
        public int restrictPlayers;
        public static List<Player> oneDayTeam = new List<Player>();
        public OneDayTeam(int restrictPlayers)
        {
            this.restrictPlayers = restrictPlayers;

        }
        public void Add(Player player)
        {
            Player p = new Player();
            if (oneDayTeam.Count >= restrictPlayers)
            {
                Console.WriteLine("Team is full");
            }
            else
            {
                Console.Write("Enter Player ID: ");
                p.PlayerId = Convert.ToInt32(Console.ReadLine());
                if (oneDayTeam.Exists(Player => Player.PlayerId == p.PlayerId))
                {
                    Console.WriteLine("Player already exists");

                }
                else
                {
                    Console.Write("Enter Player Name: ");
                    p.PlayerName = Console.ReadLine();
                    Console.Write("Enter Player Age: ");
                    p.PlayerAge = Convert.ToInt32(Console.ReadLine());
                    oneDayTeam.Add(p);
                    Console.WriteLine("Player is added successfully");
                }

            }
        }

        public List<Player> GetAllPlayers()

        {
            foreach (var item in oneDayTeam)
            {
                Console.WriteLine($"Player Id: {item.PlayerId}");
                Console.WriteLine($"Player Name: {item.PlayerName}");
                Console.WriteLine($"Player Age: {item.PlayerAge}");

            }
            return oneDayTeam;

        }

        public Player GetPlayerById(int playerId)
        {
            Console.Write("Enter Player Id: ");
            int playerIdDisplay = Convert.ToInt32(Console.ReadLine());

            foreach (var p in oneDayTeam)
            {
                if (p.PlayerId == playerIdDisplay)
                {
                    Console.WriteLine($"Player ID:{p.PlayerId} Player Name:{p.PlayerName} Player Age:{p.PlayerAge}");

                }

            }

            return null;


        }

        public Player GetPlayerByName(string playerName)
        {
            Console.Write("Enter Player Name: ");
            string playerNameDisplay = Console.ReadLine();
            foreach (var p in oneDayTeam)
            {
                if (p.PlayerName == playerNameDisplay)
                {
                    Console.WriteLine($"Player ID:{p.PlayerId} Player Name:{p.PlayerName} Player Age:{p.PlayerAge}");

                }

            }

            return null;
        }

        public void Remove(int playerId)
        {
            Console.Write("Enter player Id to be removed: ");
            int playerRemove = Convert.ToInt32(Console.ReadLine());
            Player p3 = oneDayTeam.Find(Player1 => Player1.PlayerId == playerRemove);
            if (p3 != null)
            {
                oneDayTeam.Remove(p3);
                Console.WriteLine("Player is removed successfully");
            }
            else
            {
                Console.WriteLine("Player not found");
            }
        }
    }
}
