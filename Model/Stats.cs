
using System;

namespace Ubisoft
{
    public class Stats
    {
        #region Private Member
        private string username { get; set; }

        private string match { get; set; }
        private int rank { get; set; }
        private int kills { get; set; }
        private int scores { get; set; }
        private string insertedDatetime { get; set; }

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

        public int Rank
        {
            get
            {
                return this.rank;
            }
            set
            {
                this.rank = value;
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

        public string InsertedDateTime
        {
            get
            {
                return this.insertedDatetime;
            }
            set
            {
                this.insertedDatetime = value;
            }
        }

        #endregion
    }
}
