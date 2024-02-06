using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlayerLibrary;
using System.Configuration;

namespace ProjectPhaseOneApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Player team = new Player();
            int count = Convert.ToInt32(ConfigurationManager.AppSettings["maxPlayers"]);
            OneDayTeam t1 = new OneDayTeam(count);
            string ans;
            do
            {
                
                Console.WriteLine("Enter  1.Add Player 2.Remove Player by Id 3.Get Player By Id 4. Get Player by Name 5.Get All Players 6.Exit");
                int userChoice = Convert.ToInt32(Console.ReadLine());
                switch (userChoice)
                {
                    case 1:
                        t1.Add(team);
                        break;
                    case 2:
                        t1.Remove(123);
                        break;
                    case 3:
                        t1.GetPlayerById(12);
                        break;
                    case 4:
                        t1.GetPlayerByName("preethi");
                        break;
                    case 5:
                        t1.GetAllPlayers();
                        break;
                    case 6:
                        Environment.Exit(1);
                        break;
                    default:
                        break;
                }
                Console.WriteLine("Do you want to continue?yes/no?");
                ans = Console.ReadLine();
            } while (ans == "yes");
            Console.ReadLine();
        }
    }
}
