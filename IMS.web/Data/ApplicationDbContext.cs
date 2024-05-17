﻿using IMS.web.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace IMS.web.Data
{
    public class ApplicationDbContext:IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> DbContext)
            : base(DbContext)
        {
                
        }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);


            builder.Entity<ApplicationUser>()
                .Property(e => e.FirstName)
                .IsRequired()
                .HasMaxLength(100);


            builder.Entity<ApplicationUser>()
                .Property(e => e.MiddleName)
                .HasMaxLength(100);

            builder.Entity<ApplicationUser>()
                .Property(e => e.LastName)
                .IsRequired()
                .HasMaxLength(100);

            builder.Entity<ApplicationUser>()
                .Property(e => e.Address)
                .IsRequired()
                .HasMaxLength(100);


            builder.Entity<ApplicationUser>()
                .Property(e => e.ProfileUrl)
               
                .HasMaxLength(500);


            builder.Entity<ApplicationUser>()
                .Property(e => e.IsActive)
                .HasDefaultValue(true);

            builder.Entity<ApplicationUser>()
                .Property(e => e.CreatedDate)
                .HasDefaultValueSql("GETDATE()");


            //builder.Entity<ApplicationUser>()
            //    .Property(e => e.CreatedBy)
            //    .IsRequired()
            //    .HasMaxLength(100);


            //builder.Entity<ApplicationUser>()
            //    .Property(e => e.ModifiedBy)
            //    .IsRequired()
            //    .HasMaxLength(100);


            builder.Entity<IdentityRole>()
                .ToTable("Roles")
                .Property(p => p.Id)
                .HasColumnName("RoleId");
        }
    }
}



//Application / user  authentication --> ApplicationDbContext
//database table handling  --> IMSDbContext    