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

        public void AddGoal(FootballPlayer player, int minute)
        {
            if (player != null && Goals.ContainsKey(player))
            {
                Console.WriteLine("Goal already recorded for this player.");
                return;
            }

            Goals[player] = minute;
        }

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

            Result = $" Team 1 {teamOneGoals} - {teamTwoGoals} Team 2";

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
        public void GameResult()
        {
            Console.WriteLine("Result: " + Result);
            Console.WriteLine("Winner: " + Winner);
        }
    }
}
