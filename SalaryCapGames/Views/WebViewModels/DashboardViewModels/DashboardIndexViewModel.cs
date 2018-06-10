using SalaryCapData.Data.Models;

using SalaryCapGame.Views.WebViewModels.Franchise;

using System.Collections.Generic;

namespace SalaryCapGame.Views.WebViewModels.DashboardIndexViewModel
{
    public class DashboardIndexViewModel
    {
        public FranchiseIndexModel FranchiseModel { get; set; }
        public int SelectedFranchiseId { get; set; }
        public IEnumerable<HitterStats> HittingFreeAgents { get; set; }
        public IEnumerable<PitcherStats> PitcherFreeAgents { get; set; }
    }
    //public class DashboardIndexViewModel
    //{
    //    public FranchiseIndexModel FranchiseModel { get; set; }
    //    public IEnumerable<Player> Players { get; set; }
    //}
}