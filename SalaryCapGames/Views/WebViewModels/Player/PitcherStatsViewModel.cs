


using SalaryCapData.Data.Models;

using System.Collections.Generic;

namespace SalaryCapGame.Views.WebViewModels
{
    public class PitcherStatsViewModel
    {
        public IEnumerable<PitcherStats> PitcherStats { get; set; }
        public int FranchiseId { get; set; }

    }
}
