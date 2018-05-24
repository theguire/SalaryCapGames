using SalaryCapData.Data.Models;

using System.Collections.Generic;

namespace SalaryCapGame.Views.WebViewModels.Franchise
{
    public class FranchiseIndexModel
    {
        public IEnumerable<FranchiseIndexListingModel> Franchises { get; set; }
        public IEnumerable<Player> FranchisePlayers { get; set; }
    }
}
