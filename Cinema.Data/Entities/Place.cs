using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinem.Data.Model
{
    [Index(nameof(Id), IsUnique = true)]
    internal class Place
    {
        public long Id { get; set; }
        public int row { get; set; }
        public int place { get; set; }
        public Hall hall { get; set; }
    }
}
