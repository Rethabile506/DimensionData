using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Retha_DimensionData.Models;

namespace Retha_DimensionData.Data
{
    public class Retha_DimensionDataContext : DbContext
    {
        public Retha_DimensionDataContext (DbContextOptions<Retha_DimensionDataContext> options)
            : base(options)
        {
        }

        public DbSet<Retha_DimensionData.Models.Employee> Employee { get; set; }
    }
}
