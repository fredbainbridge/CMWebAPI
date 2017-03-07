using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace CMWebAPI.Models
{
    public partial class CMContext : DbContext
    {
        public CMContext(DbContextOptions<CMContext> options) 
            : base (options)
        {

        }
        public DbSet<CMApplication> CMApplication { get; set; }
        public DbSet<ApplicationFromDBView> ApplicationFromDBView { get; set; }        
    }
}
