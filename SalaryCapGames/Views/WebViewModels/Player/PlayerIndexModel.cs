using System.Collections.Generic;

namespace SalaryCapGame.Views.WebViewModels
{
	public class PlayerIndexModel
	{
		public IEnumerable<PitcherStatsViewModel> Pitchers { get; set; }
        public IEnumerable<HitterStatsViewModel> Hitters { get; set; }
    }
}
