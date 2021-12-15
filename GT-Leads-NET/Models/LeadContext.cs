using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace GT_Leads_NET.Models
{
    public class LeadContext : DbContext
    {

        public LeadContext(DbContextOptions<LeadContext> options) : base(options)
        {

        }

        public DbSet<Lead> Leads { get; set; }
        public DbSet<Evento> Eventos { get; set; }

    }
}
