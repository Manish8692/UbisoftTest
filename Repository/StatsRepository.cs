using System;
using System.Collections.Generic;
using System.Linq;

namespace Ubisoft
{
    public class StatsRepository : IStatsRepository
    {
        private readonly IList<Stats> stats;

        #region Adding Records To the list for EndPoint as Database

        public StatsRepository() 
        {
            this.stats = new List<Stats>()
            {
                new Stats()
                {
                    Kills = 20,
                    Match = "csGo",
                    Rank = 1,
                    Scores = 400,
                    Username = "xyz",
                    InsertedDateTime = DateTime.Now.ToString()
                },
                new Stats()
                {
                    Kills = 16,
                    Match = "csGo",
                    Rank = 2,
                    Scores = 320,
                    Username = "abc",
                    InsertedDateTime = DateTime.Now.ToString()
                },
                new Stats()
                {
                    Kills = 12,
                    Match = "pubg",
                    Rank = 3,
                    Scores = 240,
                    Username = "a1a2",
                    InsertedDateTime = DateTime.Now.ToString()
                }
            };
        }

        #endregion

        public IList<Stats> GetStats(string match, string time)
        {
            try
            {
                // Considering to call the Actual DB 
                // Taking top 10 highest records
                // here time will be range 
                IList<Stats> statsList = this.stats.Where(item => item.Match.ToLower().Equals(match.ToLower()) && Convert.ToDateTime(item.InsertedDateTime) > Convert.ToDateTime(time))
                     .OrderByDescending(item => item.Rank)
                     .Take(10)
                     .ToList();

                return statsList;
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}
