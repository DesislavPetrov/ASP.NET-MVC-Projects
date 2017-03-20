using DesislavsPieShop.Models;
using System;
using System.Collections.Generic;

namespace DesislavsPieShop.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Pie> PiesOfTheWeek { get; set; }
    }
}
