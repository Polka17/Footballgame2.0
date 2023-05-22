using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballGamePt2
{
    public class Team
    {
        private FootballPlayer[] players;
        public Coach Coach { get; set; }
        public FootballPlayer[] Players 
        {
            get { return players; }
            set 
            { 
                if(value.Length < 11 || value.Length > 22)
                {
                    throw new ArgumentException("Fella, you can't have too litlle or too many chimichangas in here!");
                }
                players = value;
            } 
        }

        private double age;
        private double GetTeamAverageAge(FootballPlayer[] players)
        {
            foreach (var player in players)
            {
                age += player.Age;
            }
            return age / players.Length;
        }
    }
}
