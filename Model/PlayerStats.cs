

namespace Ubisoft
{
    public class PlayerStats
    {
        #region Private Member

        private string username { get; set; }
        private string match { get; set; }

        private int kills { get; set; }

        private int scores { get; set; }

        #endregion

        #region Public Member

        public string Username
        {
            get
            {
                return this.username;
            }
            set
            {
                this.username = value;
            }
        }
        public string Match
        {
            get
            {
                return this.match;
            }
            set
            {
                this.match = value;
            }
        }

        public int Kills
        {
            get
            {
                return this.kills;
            }
            set
            {
                this.kills = value;
            }
        }

        public int Scores
        {
            get
            {
                return this.scores;
            }
            set
            {
                this.scores = value;
            }
        }

        #endregion
    }
}
