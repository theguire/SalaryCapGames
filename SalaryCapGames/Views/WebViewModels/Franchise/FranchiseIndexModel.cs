using SalaryCapData.Data.Models;
using System.Collections.Generic;

namespace SalaryCapGame.Views.WebViewModels
{
    public class FranchiseIndexModel
    {
        public IEnumerable<FranchiseIndexListingModel> Franchises { get; set; }
        public IEnumerable<PlayerAssignment> PlayerAssignments { get; set; }
    }
}
