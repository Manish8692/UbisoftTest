using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Ubisoft
{
    //[Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class StatsController : ControllerBase
    {
        private readonly IServiceProvider _services;

        public StatsController(IServiceProvider service)
        {
            this._services = service;
        }

        #region Question 2

        [HttpGet]
        [Route("leaderBoard")]
        public IList<Stats> GetStats(string match, string time)
        {
            try
            {
                return new StatsManager(this._services).GetStats(match,time);
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion

    }
}