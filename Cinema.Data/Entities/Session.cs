using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinem.Data.Model
{
    [Index(nameof(Id), IsUnique = true)]
    internal class Session
    {
        public long Id { get; set; }
        public DateTime date { get; set; }
        public Movie movie { get; set; }
        public Hall Hall { get; set; }
        public float coefficient { get; set; }

    }
}
