using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NavbarAnimation.Maui.Models
{
    public class LocationModel
    {
        public string LocationName { get; set; } = null!;
        public double LocationRating { get; set; }

        public string LocationAddress { get; set; } = null!;
        public string Locationlatitude { get; set; } = null!;
        public string Locationlongitude { get; set; } = null!;

        public string FavoriteIcon { get; set; } = "outline_star.png";

    }
}
