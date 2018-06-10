using SalaryCapData.Data.Models;

using System.Collections.Generic;

namespace SalaryCapGames.Views.WebViewModels
{
    public class PitcherWebViewModel
    {
        public int CurrentFranchiseId { get; set; }
        public IEnumerable<Player> Pitchers { get; set; }
    }
}
