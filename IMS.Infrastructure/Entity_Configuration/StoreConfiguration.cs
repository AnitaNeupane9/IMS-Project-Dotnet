﻿using IMS.Models.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.Infrastructure.Entity_Configuration
{  
    public class StoreConfiguration : IEntityTypeConfiguration<Storeinfo>
    {
        public void Configure(EntityTypeBuilder<Storeinfo> builder)
        {
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id)
                .ValueGeneratedOnAdd();

            builder.Property(e => e.StoreName)
                .HasMaxLength(100)
                .IsUnicode(true);

            builder.Property(e => e.Address)
                .HasMaxLength(100)
                .IsUnicode(true);

            builder.Property(e => e.PhoneNumber)
                .HasMaxLength(20)
                .IsUnicode(true);

            builder.Property(e => e.RegistrationNumber)
                .HasMaxLength(50)
                .IsUnicode(true);

            builder.Property(e => e.PanNo)
                .HasMaxLength(50)
                .IsUnicode(true);

            builder.Property(e => e.IsActive)
                .HasDefaultValue(true);

            builder.Property(e => e.CreatedDate)
               .HasDefaultValueSql("GETDATE()");


            builder.Property(e => e.CreatedBy)
                //.IsRequired()
                .IsUnicode(true);

            builder.Property(e => e.ModifiedDate)
                .HasColumnType("datetime");

            builder.Property(e => e.ModifiedBy)
                //.IsRequired()
                .IsUnicode(false);

        }
    }
}