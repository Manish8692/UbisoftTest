using System;
using System.Collections.Generic;
using System.Text;

namespace Ubisoft
{
    public interface IPlayerStatesRepository
    {
        IList<PlayerStats> AddPlayerStats(IList<PlayerStats> playerStats);

        IList<PlayerStats> GetCurrentLoginPlayerStats(string usernameOrID);

        IList<PlayerStats> GetPlayerStats(string match, string timeframe);
    }
}
