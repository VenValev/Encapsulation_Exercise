using System;
using System.Collections.Generic;
using System.Text;

namespace _05_Football_Team_Generator
{
    public class Team
    {
        private string name;
        private int rating;
        private readonly List<Player> players;

        public Team()
        {
            players = new List<Player>();
        }
        public Team(string name)
            :this()
        {

        }
    }
}
