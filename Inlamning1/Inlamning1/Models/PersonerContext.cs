using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inlamning1.Models
{
    internal class PersonerContext : DbContext
    {
        public DbSet<Personer> Folk { get; set; }
    }
}