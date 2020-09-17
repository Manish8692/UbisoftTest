using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Ubisoft
{
    public class PlayerStatsRepository : IPlayerStatesRepository
    {
        private readonly IList<PlayerStats> testData;

        #region Adding Records To the list for EndPoint as Database

        public PlayerStatsRepository() 
        {
            this.testData = new List<PlayerStats>()
            {
                new PlayerStats()
                {
                    Kills = 10,
                    Match = "csGo",
                    Scores = 200,
                    Username = "abc"
                },
                new PlayerStats()
                {
                    Kills = 5,
                    Match = "csGo",
                    Scores = 200,
                    Username = "xyz"
                },
                 new PlayerStats()
                {
                    Kills = 20,
                    Match = "csGo",
                    Scores = 200,
                    Username = "a1a2"
                }
            };
        }

        #endregion

        public IList<PlayerStats> AddPlayerStats(IList<PlayerStats> playrStates)
        {
            try
            {
                throw new NotImplementedException();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public IList<PlayerStats> GetCurrentLoginPlayerStats(string usernameOrID)
        {
            try
            {
                return this.testData.Where(item => item.Username.Equals(usernameOrID)).ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public IList<PlayerStats> GetPlayerStats(string match, string timeframe)
        {
            try
            {
                return this.testData.Take(100).ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}
