using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinem.Data.Model
{
    [Index(nameof(Id), IsUnique = true)]
    internal class PlacesOfSession
    {
        public long Id { get; set; }
        public Session session { get; set; }
        public Place place { get; set; }
        public Ticket ticket { get; set; }

    }
}
