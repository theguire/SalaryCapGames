
using SalaryCapData.Data.Models;

using System.ComponentModel.DataAnnotations;

namespace SalaryCapGame.Views.WebViewModels
{
    public class FranchiseIndexListingModel
    {
        public int Id { get; set; }
        public string Nickname { get; set; }

        public string OwnerId { get; set; }
        public int LeagueId { get; set; }

        public League League { get; set; }
        public ApplicationUser Owner { get; set; }

        [DisplayFormat( DataFormatString = "{0:N}" )]
        public long Points { get; set; }

        [DisplayFormat( DataFormatString = "{0:C}" )]
        public decimal Value { get; set; }

        [Display( Name = "Trades" )]
        public int NumberOfTrades { get; set; }

        

    }
}
