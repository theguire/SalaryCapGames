using System.ComponentModel.DataAnnotations;

namespace SalaryCapGames.Views.WebViewModels.ManageViewModels
{
    public class IndexViewModel
    {
        public string Username { get; set; }

        public bool IsEmailConfirmed { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Phone]
        [Display( Name = "Phone number" )]
        public string PhoneNumber { get; set; }

        public string StatusMessage { get; set; }
    }
}
