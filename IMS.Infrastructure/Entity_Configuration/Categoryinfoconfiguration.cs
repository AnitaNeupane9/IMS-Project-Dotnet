using IMS.Models.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.Infrastructure.Entity_Configuration
{
    public class Categoryinfoconfiguration : IEntityTypeConfiguration<CategoryInfo>
    {
        public void Configure(EntityTypeBuilder<CategoryInfo> builder)
        {
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id)
                .ValueGeneratedOnAdd();


            builder.Property(e => e.CategoryName)
                .HasMaxLength(100)
                .IsUnicode(true);

            builder.Property(e => e.CategoryDescription)
                .HasMaxLength(100)
                .IsUnicode(true);


            builder.HasOne(e => e.Storeinfo)
                .WithMany(pt => pt.CategoryInfos)
                .HasForeignKey(e => e.StoreinfoId);


            builder.HasMany(e => e.ProductInfos)
                .WithOne(pt => pt.CategoryInfo)
                .HasForeignKey(e => e.CategoryInfoId);


            builder.HasMany(e => e.ProductRateInfos)
                .WithOne(pt => pt.CategoryInfo)
                .HasForeignKey(e => e.CategoryInfoId);

            builder.HasMany(e => e.StockInfos)
                .WithOne(pt => pt.CategoryInfo)
                .HasForeignKey(e => e.CategoryInfoId);


            builder.HasMany(e => e.TransactionInfos)
                .WithOne(pt => pt.CategoryInfo)
                .HasForeignKey(e => e.CategoryInfoId);


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
