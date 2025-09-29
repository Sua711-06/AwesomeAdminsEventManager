using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AwesomeAdminsPartyManager.Models;

namespace AwesomeAdminsPartyManager.Data
{
    public class AwesomeAdminsPartyManagerContext : DbContext
    {
        public AwesomeAdminsPartyManagerContext (DbContextOptions<AwesomeAdminsPartyManagerContext> options)
            : base(options)
        {
        }

        public DbSet<AwesomeAdminsPartyManager.Models.Party> Party { get; set; } = default!;
    }
}
