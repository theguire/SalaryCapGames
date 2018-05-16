using System.Collections.Generic;

namespace SalaryCapGame.Views.WebViewModels
{
    public class StatsModel
    {
        public IEnumerable<HitterStatsViewModel> HitterViewStats { get; set; }
        public IEnumerable<PitcherStatsViewModel> PicthterViewStats { get; set; }

    }
}
