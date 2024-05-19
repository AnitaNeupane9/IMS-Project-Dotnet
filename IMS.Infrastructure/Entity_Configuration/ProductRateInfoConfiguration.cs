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
    public class ProductRateInfoConfiguration : IEntityTypeConfiguration<ProductRateInfo>
    {
        public void Configure(EntityTypeBuilder<ProductRateInfo> builder)
        {
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id)
                .ValueGeneratedOnAdd();


            builder.Property(e => e.CostPrice)
                .HasColumnType("float");

            builder.Property(e => e.SellingPrice)
                .HasColumnType("float");

            builder.Property(e => e.Quantity)
                .HasColumnType("float");

            builder.Property(e => e.SoldQuantity)
                .HasColumnType("float");

            builder.Property(e => e.RemainingQuantity)
                .HasColumnType("float");

            builder.Property(e => e.BatchNo)
                .HasMaxLength(200)
                .IsUnicode(true);


            builder.Property(e => e.PurchaseDate)
                .IsRequired()
                .HasColumnType("datetime");

            builder.Property(e => e.ExpiryDate)
                .HasColumnType("datetime");



            builder.HasOne(e => e.CategoryInfo)
                .WithMany(pt => pt.ProductRateInfos)
                .HasForeignKey(e => e.CategoryInfoId);

            builder.HasOne(e => e.ProductInfo)
                .WithMany(pt => pt.ProductRateInfos)
                .HasForeignKey(e => e.ProductInfoId);

            builder.HasOne(e => e.Storeinfo)
                .WithMany(pt => pt.ProductRateInfos)
                .HasForeignKey(e => e.StoreinfoId);

            builder.HasOne(e => e.SupplierInfo)
                .WithMany(pt => pt.ProductRateInfos)
                .HasForeignKey(e => e.SupplierInfoId);

            builder.HasOne(e => e.RackInfo)
                .WithMany(pt => pt.ProductRateInfos)
                .HasForeignKey(e => e.RackInfoId);

            builder.HasMany(e => e.ProductInvoiceDetailInfos)
                .WithOne(pt => pt.ProductRateInfo)
                .HasForeignKey(e => e.ProductRateInfoId);

            builder.HasMany(e => e.TransactionInfos)
                .WithOne(pt => pt.ProductRateInfo)
                .HasForeignKey(e => e.ProductRateInfoId);

            builder.HasMany(e => e.StockInfos)
                .WithOne(pt => pt.ProductRateInfo)
                .HasForeignKey(e => e.productRateInfoId);

        }
    }
}
