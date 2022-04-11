using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinem.Data.Model
{
    [Index(nameof(Id), IsUnique = true)]
    internal class Hall
    {
        public long Id { get; set; }
        public string title { get; set; }
        public Cinema cinema { get; set; }
        public HallTypes hallTypes { get; set; }
    }
}
