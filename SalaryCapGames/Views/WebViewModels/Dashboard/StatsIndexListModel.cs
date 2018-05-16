using SalaryCapData.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalaryCapGame.Views.WebViewModels
{
    public class StatsIndexListModel
    {
        //public int TotalPoints { get; set; }
        public IEnumerable<HitterStats> HitterStats { get; set; }
        public IEnumerable<PitcherStats> PitcherStats { get; set; }
    }
}
