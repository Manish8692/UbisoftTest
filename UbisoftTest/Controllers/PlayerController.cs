using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;

namespace Ubisoft
{
   // [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class PlayerController : ControllerBase
    {
        private readonly IServiceProvider _services;

        public PlayerController(IServiceProvider services)
        {
            this._services = services;
        }

        #region Question 1

        [HttpPost]
        [Route("playerStats")]
        public IList<PlayerStats> AddPlayerStats(IList<PlayerStats> playerStats)
        {
            try
            {
               return new PlayerStatsManager(this._services).AddPlayerStats(playerStats);
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion

        #region Question 3

        [HttpGet]
        [Route("playerStats")]
        public IList<PlayerStats> GetCurrentLoginPlayerStats(string usernameOrId)
        {
            try
            {
                return new PlayerStatsManager(this._services).GetCurrentLoginPlayerStats(usernameOrId);
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion

        #region Question 4

        [HttpGet]
        [Route("playerStats")]
        public IList<PlayerStats> GetPlayerStats(string match, string timeframe)
        {
            try
            {
                return new PlayerStatsManager(this._services).GetPlayerStats(match, timeframe);
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion

    }
}
