using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partita
{
    class Program
    {
        static void Main(string[] args)
        {
            int FirstPlayer = 0;
            int SecondPlayer = 0;
            int ThirdPlayer = 0;
            int FourPlayer = 0;
            int resultMatch = 0;


            string data = Console.ReadLine();
            while (data != "Partita")
            {
                string[] array = data.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string firstTeam = array[0];
                string result = array[1];
                string secondTeam = array[2];

                int firstTeamPoints = 0;
                int secondTeamPoints = 0;

                if (result == "1")
                {
                    firstTeamPoints += 1;
                }
                else if (result == "2")
                {
                    secondTeamPoints += 1;
                }

                switch (firstTeam)
                {
                    case "Goal giocatore 1": FirstPlayer += firstTeamPoints; break;
                    case "Goal giocatore 2": SecondPlayer += firstTeamPoints; break;

                }

                switch (secondTeam)
                {
                    case "Goal giocatore 3": ThirdPlayer += firstTeamPoints; break;
                    case "Goal giocatore 4": FourPlayer += firstTeamPoints; break;
                }
                
                for (int i = 0; i < array.Length; i++)
                {
                    resultMatch++;
                }

                Console.WriteLine("Risultato della partita {0}", resultMatch);

            }
        }
    }
}
