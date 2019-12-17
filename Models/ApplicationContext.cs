using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication11.Models
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions options) : base(options)
        { }
        public DbSet<Template> Templates { get; set; }
        public DbSet<Questions> Questions { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Template>()
            .HasMany(q => q.Questions)
            .WithOne(t => t.Template).IsRequired().HasForeignKey(x=>x.TemplateId).OnDelete(DeleteBehavior.NoAction);

        }

    }
}

