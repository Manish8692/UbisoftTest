using System;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Extensions.DependencyInjection;

namespace Ubisoft
{
    public class PlayerStatsManager
    {
        private readonly IServiceProvider _services;
        private readonly IPlayerStatesRepository iplayerStatsRepository;
        public PlayerStatsManager(IServiceProvider services)
        {
            this._services = services;
            this.iplayerStatsRepository = this._services.GetService<IPlayerStatesRepository>();
        }

        /// <summary>
        /// Adding player stats , adding business logic if there is
        /// </summary>
        /// <param name="playerStats"></param>
        /// <returns></returns>
        public IList<PlayerStats> AddPlayerStats(IList<PlayerStats> playerStats)
        {
            try
            {
                return this.iplayerStatsRepository.AddPlayerStats(playerStats);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public IList<PlayerStats> GetCurrentLoginPlayerStats(string usernameOrId)
        {
            try
            {
                return this.iplayerStatsRepository.GetCurrentLoginPlayerStats(usernameOrId);
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
                return this.iplayerStatsRepository.GetPlayerStats(match, timeframe);
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}
