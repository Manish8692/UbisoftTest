using System;
using System.Collections.Generic;
using System.Text;

namespace Ubisoft
{
    public interface IStatsRepository
    {
        IList<Stats> GetStats(string match, string time);
    }
}
