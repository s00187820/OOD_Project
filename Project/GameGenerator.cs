using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class GameGenerator
    {
        public string GameRating { get; set; }
        public decimal GameScore { get; set; }

        public GameGenerator(string gameRating, decimal gameScore)
        {
            GameRating = gameRating;
            GameScore = gameScore;
        }

        public GameGenerator(string gameRating) : this(gameRating, 0) { }

        public GameGenerator() : this("Unknown Score") { }

        public override string ToString()
        {
            return string.Format("[{0}] {1} {2:C}", 
                this.GetType().Name.ToUpper(), 
                GameRating, GameScore);
            
        }
    }
}
