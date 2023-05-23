using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace FootballGamePt2
{
    public class Game
    {
        private Team teamOne;
        private Team teamTwo;
        public Game()
        {
            Goals = new Dictionary<FootballPlayer, int>();
        }
        public Team TeamOne 
        {
            get { return teamOne; }
            set
            {
                // (1) had to research a bit here about 'value' since I got confused at first with the null references and got stuck there...
                if(value.Players.Length != 11)
                {
                    throw new ArgumentException("Only 11 players allowed on the field!!");
                }
                teamOne = value;
            } 
        }
        public Team TeamTwo
        {
            get { return teamTwo; }
            set
            {
                //same here --> (1)
                if (value.Players.Length != 11)
                {
                    throw new ArgumentException("Only 11 players allowed on the field!!");
                }
                teamTwo = value;
            }
        }
        public Referee[] Referees { get; set; }
        public Dictionary<FootballPlayer, int> Goals { get; set; }
        public string Result { get; set; }
        public string Winner { get; set; }


        //Add goal if it is not a null value or if it isn't already scored. Assign the minute(value) to the player(key)
        public void AddGoal(FootballPlayer player, int minute)
        {
            if (player != null && Goals.ContainsKey(player))
            {
                Console.WriteLine("This goal is alredy added!");
                return;
            }

            Goals[player] = minute;
        }

        //check in which team is the player that scored, increase the said team goals, compare them and get winner
        public void ChangeResult()
        {
            int teamOneGoals = 0;
            int teamTwoGoals = 0;

            foreach (var goal in Goals)
            {
                if (TeamOne.Players.Contains(goal.Key))
                {
                    teamOneGoals++;
                }
                else if (TeamTwo.Players.Contains(goal.Key))
                {
                    teamTwoGoals++;
                }
            }

            Result = $" Team 1 |{teamOneGoals} - {teamTwoGoals}| Team 2";

            if (teamOneGoals > teamTwoGoals)
            {
                Winner = "Team1";
            }
            else if (teamTwoGoals > teamOneGoals)
            {
                Winner = "Team2";
            }
            else
            {
                Winner = "Draw";
            }
        }

        //Showing players, coaches, referees, goals and result + winner
        public void GameResult()
        {
            Console.WriteLine("-----TEAM 1-----");
            foreach(var player in TeamOne.Players)
            {
                Console.WriteLine($"{player.Name} №{player.Number}");
            }
            Console.WriteLine("-----Coach-----");
            Console.WriteLine(TeamOne.Coach.Name);
            Console.WriteLine();

            Console.WriteLine("-----TEAM 2-----");
            foreach (var player in TeamTwo.Players)
            {
                Console.WriteLine($"{player.Name} №{player.Number}");
            }
            Console.WriteLine("-----Coach-----");
            Console.WriteLine(TeamTwo.Coach.Name);
            Console.WriteLine();

            Console.WriteLine("-----REFEREES-----");
            foreach (var referees in Referees)
            {
                Console.WriteLine(referees.Name);
            }
            Console.WriteLine();

            Console.WriteLine("-----GOALS-----");
            foreach (var goal in Goals)
            {
                Console.WriteLine($"Goal in {goal.Value} by {goal.Key.Name}");
            }
            Console.WriteLine();

            Console.WriteLine("RESULT: " + Result);
            Console.WriteLine("WINNER: " + Winner);
        }
    }
}
