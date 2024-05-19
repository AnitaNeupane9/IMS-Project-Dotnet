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
    public class ProductInfoConfiguration : IEntityTypeConfiguration<ProductInfo>
    {
        public void Configure(EntityTypeBuilder<ProductInfo> builder)
        {
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id)
                .ValueGeneratedOnAdd();


            builder.Property(e => e.ProductName)
                .HasMaxLength(200)
                .IsUnicode(true);

            builder.Property(e => e.ProductDescription)
                .HasMaxLength(500)
                .IsUnicode(true);

            builder.Property(e => e.ImageUrl)
                .HasMaxLength(500)
                .IsUnicode(true);


            builder.HasOne(e => e.Storeinfo)
                .WithMany(pt => pt.ProductInfos)
                .HasForeignKey(e => e.StoreinfoId);

            builder.HasOne(e => e.CategoryInfo)
                .WithMany(pt => pt.ProductInfos)
                .HasForeignKey(e => e.CategoryInfoId);

            builder.HasOne(e => e.UnitInfo)
                .WithMany(pt => pt.ProductInfos)
                .HasForeignKey(e => e.UnitInfoId);


            builder.HasMany(e => e.ProductRateInfos)
                .WithOne(pt => pt.ProductInfo)
                .HasForeignKey(e => e.ProductInfoId);

            builder.HasMany(e => e.TransactionInfos)
                .WithOne(pt => pt.ProductInfo)
                .HasForeignKey(e => e.ProductInfoId);

            builder.HasMany(e => e.StockInfos)
                .WithOne(pt => pt.ProductInfo)
                .HasForeignKey(e => e.ProductInfoId);
        }
    }
}
