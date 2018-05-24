using SalaryCapGame.Views.WebViewModels;

namespace SalaryCapGames.Views.WebViewModels.Dashboard
{
    //public class DashboardViewModel
    //{
    //    IEnumerable<FranchiseIndexListingModel> FranchiseList { get; set; }
    //    int SelectedFranchiseId { get; set; }
    //    IEnumerable<HitterStatsViewModel> HittingFreeAgents { get; set; }
    //    IEnumerable<HitterStatsViewModel> PitcherFreeAgents { get; set; }
    //}
    public class DashboardViewModel
    {
        public FranchiseIndexModel FranchiseModel { get; set; }
        public StatsIndexListModel AllPlayerStats { get; set; }
    }
}