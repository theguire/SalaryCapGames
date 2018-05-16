using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalaryCapGame.Views.WebViewModels.Franchise
{
    public class EditFranchiseModel
    {
        public int Id { get; set; }
        public int OwnerId { get; set; }
        public int LeagueId { get; set; }
        public string AbbreviatedName { get; set; }
        public string ImageUrl { get; set; }
        public string Name { get; set; }
    }
}
