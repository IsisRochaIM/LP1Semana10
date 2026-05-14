using System.Drawing;

namespace ArcadeLog
{
    public class Score : IComparable<Score>
    {
        private int points;

        public string Name{get;}

        public int Points
        {
            get
            {
                return points;
            }

            set
            {
                points = value;
                if(points < 0)
                {
                    points = 0;
                }
                if(points > 9999)
                {
                    points = 9999;
                }
            }
        }

        public string Medal
        {
            get
            {
                if(points >= 7000)
                {
                    return "Gold";
                }
                else if(points >= 4000)
                {
                    return "Silver";
                }
                else
                {
                    return "Bronze";
                }
            }
        }

        public Score(string n, int p)
        {
            Name = n;
            points = p;
        }


        public int CompareTo(Score other)
        {
            if(other.Points == 0) return 1;
            return other.Points - this.Points;
        }

        public override string ToString()
        {
            
            return $"{this.Name} [{this.Medal}]: {this.Points}";
        }
    }
}
