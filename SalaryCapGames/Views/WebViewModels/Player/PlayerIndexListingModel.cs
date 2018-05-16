using SalaryCapData.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalaryCapGame.Views.WebViewModels
{
	public class PlayerIndexListingModel
	{
		public int PlayerId { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string FullName
		{
			get { return FirstName + " " + LastName; }
		}
		public decimal Value { get; set; }
		public int TotalPoints { get; set; }

		public Team Team { get; set; }
		public string Position { get; set; }


		public HitterStats HitterStats { get; set; }
		public PitcherStats PitcherStats { get; set; }
	}
}
