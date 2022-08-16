using System;
using System.Collections.Generic;
using System.Text;

namespace _05_Football_Team_Generator
{
    public class Player
    {
        private string name;
        private int endurance;
        private int sprint;
        private int dribble;
        private int passing;
        private int shooting;
        private double avrgStat;

        public Player(string name, int endurance, int sprint, int dribble, int passing, int shooting)
        {
            this.Name = name;
            this.Endurance = endurance;
            this.Sprint = sprint;
            this.Dribble = dribble;
            this.Passing = passing;
            this.Shooting = shooting;
        }

        public string Name 
        { 
            get => this.name; 
            private set
            {
                if(String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(ExeptMsg.invalidNameExep);
                }
                this.name = value;
            }
        }
        public int Endurance
        {
            get => this.endurance;
            private set
            {
                if(value < 0 || value > 100)
                {
                    throw new ArgumentException(String.Format(ExeptMsg.invalidStatExep, "Endurance"));
                }
                this.endurance = value;
            }
        }
        public int Sprint
        {
            get => this.sprint;
            private set
            {
                if (value < 0 || value > 100)
                {
                    throw new ArgumentException(String.Format(ExeptMsg.invalidStatExep, "Sprint"));
                }
                this.sprint = value;
            }
        }
        public int Dribble
        {
            get => this.dribble;
            private set
            {
                if (value < 0 || value > 100)
                {
                    throw new ArgumentException(String.Format(ExeptMsg.invalidStatExep, "Dribble"));
                }
                this.dribble = value;
            }
        }
        public int Passing
        {
            get => this.passing;
            private set
            {
                if (value < 0 || value > 100)
                {
                    throw new ArgumentException(String.Format(ExeptMsg.invalidStatExep, "Passing"));
                }
                this.passing = value;
            }
        }
        public int Shooting
        {
            get => this.shooting;
            private set
            {
                if (value < 0 || value > 100)
                {
                    throw new ArgumentException(String.Format(ExeptMsg.invalidStatExep, "Shooting"));
                }
                this.shooting = value;
            }
        }

        public double AverageStats()
        {
            double avrg = (this.Endurance + this.Sprint + this.Dribble + this.Passing + this.Shooting) / 5.0;

            return Math.Round(avrg, 3);
        }
    }
}
