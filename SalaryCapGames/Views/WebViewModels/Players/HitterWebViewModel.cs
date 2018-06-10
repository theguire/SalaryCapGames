﻿using SalaryCapData.Data.Models;

using System.Collections.Generic;

namespace SalaryCapGames.Views.WebViewModels
{
    public class HitterWebViewModel
    {
        public int CurrentFranchiseId { get; set; }
        public IEnumerable<Player> Hitters { get; set; }
    }
}