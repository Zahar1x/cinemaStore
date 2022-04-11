using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinem.Data.Model
{
    [Index(nameof(Id), IsUnique = true)]
    internal class HallTypes
    {
        public long Id { get; set; }
        public string type { get; set; }
        public float coefficient { get; set; }

    }
}
