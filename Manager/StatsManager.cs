using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.DependencyInjection;

namespace Ubisoft
{
    public class StatsManager
    {
        private readonly IServiceProvider _services;
        private readonly IStatsRepository iStatsRepository;
        public StatsManager(IServiceProvider services)
        {
            this._services = services;
            this.iStatsRepository = this._services.GetService<IStatsRepository>();
        }

        public IList<Stats> GetStats(string match, string time)
        {
            try
            {
                return this.iStatsRepository.GetStats(match, time);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
