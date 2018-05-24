using SalaryCapData.Data.Models;

using SalaryCapGame.Views.WebViewModels.Franchise;

using System.Collections.Generic;

namespace SalaryCapGames.Views.WebViewModels.DashboardViewModels
{
    //public class DashboardViewModel
    //{
    //    IEnumerable<FranchiseIndexListingModel> FranchiseList { get; set; }
    //    int SelectedFranchiseId { get; set; }
    //    IEnumerable<HitterStatsViewModel> HittingFreeAgents { get; set; }
    //    IEnumerable<HitterStatsViewModel> PitcherFreeAgents { get; set; }
    //}
    public class DashboardIndexViewModel
    {
        public FranchiseIndexModel FranchiseModel { get; set; }
        public IEnumerable<Player> Players { get; set; }
    }
}