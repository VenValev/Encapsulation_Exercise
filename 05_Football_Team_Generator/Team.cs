using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _05_Football_Team_Generator
{
    public class Team
    {
        private string name;
        private int rating;
        private readonly List<Player> players;

        private Team()
        {
            players = new List<Player>();
        }
        public Team(string name)
            :this()
        {
            this.Name = name;
        }

        public string Name
        {
            get => this.name;
            private set
            {
                if(String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException(ExeptMsg.invalidNameExep);
                }

                this.name = value;
            }
        }
        public int Rating
        {
            get => this.rating;
            private set
            {
                this.rating = value;
            }
        }

        public void AddPlayer(Player player)
        {
            this.players.Add(player);
        }

        public void RemovePlayer(string playerName)
        {
            Player plToDel = this.players
                .FirstOrDefault(p => p.Name == playerName);
            if(plToDel == null)
            {
                throw new AggregateException(String
                    .Format(ExeptMsg.missingPlayerInTeam, playerName, this.Name));
            }
            this.players.Remove(plToDel);
        }

    }
}
