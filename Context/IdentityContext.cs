using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IdentityManagerAPI.Models;

namespace IdentityManagerAPI.Context
{
    public class IdentityContext : DbContext
    {
        public IdentityContext(DbContextOptions<IdentityContext> options) : base(options) { }
        public DbSet<Users> Users { get; set; }
        public DbSet<Roles> Roles { get; set; }
        public DbSet<Systems> Systems { get; set; }

        //protected override void OnModelCreating (ModelBuilder builder) 
        // {
        //base.OnModelCreating(builder);

        // builder.Entity<User>().ToTable("Users");
        //builder.Entity<User>().HasKey(p => p.Id);
        // builder.Entity<User>().Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();
        //builder.Entity<User>().Property(p => p.EmployeeID).IsRequired().HasMaxLength(6);
        //builder.Entity<User>().Property(p => p.DisplayName).IsRequired().HasMaxLength(255);
        //builder.Entity<User>().Property(p => p.AccountName).IsRequired().HasMaxLength(6);
        //builder.Entity<User>().Property(p => p.EmployeeStatus).IsRequired().HasMaxLength(255);
        //builder.Entity<User>().Property(p => p.EmployeeStartDate).IsRequired().HasMaxLength(255);
        //builder.Entity<User>().Property(p => p.EmployeeEndDate).IsRequired().ValueGeneratedNever();
        //builder.Entity<User>().Property(p => p.ManagerID).IsRequired().HasMaxLength(3);
        // builder.Entity<User>().Property(p => p.Company).IsRequired().HasMaxLength(255);
        //builder.Entity<User>().Property(p => p.Department).IsRequired().HasMaxLength(255);
        //builder.Entity<User>().Property(p => p.JobTitle).IsRequired().HasMaxLength(255);


        //builder.Entity<Roles>().ToTable("Roles");
        //builder.Entity<Roles>().HasKey(p => p.Id);
        //builder.Entity<Roles>().Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();
        //builder.Entity<Roles>().Property(p => p.Role).IsRequired().HasMaxLength(6);
        //builder.Entity<Roles>().Property(p => p.users).IsRequired().HasMaxLength(3);
        //builder.Entity<Roles>().Property(p => p.System).IsRequired().HasMaxLength(2);



        //}

    }
}
