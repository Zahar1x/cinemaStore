using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinem.Data.Model
{
    [Index(nameof(Id), IsUnique = true)]
    internal class Cinema
    {
        public long Id { get; set; }
        public string name { get; set; }
        public string address { get; set; }

    }
}
