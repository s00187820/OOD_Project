using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public enum Corporation { Genre, Website, List }
    class Game
    {
        #region Properties

        public string CompanyName { get; set; }
        public string CompanyGame { get; set; }
        public string GameInfo { get; set; }
        public string CompanyImage { get; set; }
        public double GameScore { get; set; }
        public Corporation CorporationInfo { get; set; }
        public DateTime ReleaseDate { get; set; }


        #endregion Properties

        public string GameScore_Colour
        {
            get
            {
                if (GameScore >= 80)
                    return "Green";
                if (GameScore >= 60)
                    return "Orange";
                else
                    return "Red";
            }
        }
    }
}
