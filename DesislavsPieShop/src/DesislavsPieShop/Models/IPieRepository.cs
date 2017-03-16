using System.Collections.Generic;

namespace DesislavsPieShop.Models
{
    public interface IPieRepository
    {
        IEnumerable<Pie> Pies {get;}
        IEnumerable<Pie> PiesOfTheWeek { get; }

        Pie GetPieById(int pieId);
    }
}
