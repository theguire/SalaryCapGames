using System.ComponentModel.DataAnnotations;

namespace SalaryCapGames.Views.WebViewModels.League
{
    public class LeagueViewModel
    {
        [StringLength( 50, MinimumLength = 5,
                    ErrorMessage = "League name must be between 5 - 50 characters." )]
        [RegularExpression( @"^[A-Za-z0-9-]*$" )]
        public string Name { get; set; }
        [Display( Name = "League Size" )]
        [Range( 6, 20 )]
        public int MaxSize { get; set; }
        public bool IsPrivate { get; set; }
    }
}
