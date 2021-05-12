using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Movie_Plus.DataModel;

namespace Movie_Plus.Data
{
    public class CinePlusDbContext : IdentityDbContext
    {
        public CinePlusDbContext()
        {}

        public CinePlusDbContext(DbContextOptions<CinePlusDbContext> options)
            : base(options)
        { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseLazyLoadingProxies();
        }

        public DbSet<TestModelClass> Test { get; set; }
    }
}
