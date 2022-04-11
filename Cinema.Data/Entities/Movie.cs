using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinem.Data.Model
{
    [Index(nameof(Id), IsUnique = true)]
    internal class Movie
    {
        public long Id { get; set; }
        public string name { get; set; }
        public int duration { get; set; }
        public string language { get; set; }
        public string ageRating { get; set; }
        public string genre { get; set; }
        public int age { get; set; }
        public string about { get; set; }
        public int basePrice { get; set; }

    }
}
