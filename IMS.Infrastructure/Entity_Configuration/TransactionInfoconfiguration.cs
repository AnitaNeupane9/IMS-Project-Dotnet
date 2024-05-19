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
    public class TransactionInfoconfiguration : IEntityTypeConfiguration<TransactionInfo>
    {
        public void Configure(EntityTypeBuilder<TransactionInfo> builder)
        {
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id)
                .ValueGeneratedOnAdd();


            builder.Property(e => e.Transactiontype)
                .HasMaxLength(200)
                .IsUnicode(true);

            builder.Property(e => e.Rate)
                .HasColumnType("float");

            builder.Property(e => e.Quantity)
                .HasColumnType("float");

            builder.Property(e => e.Amount)
                .HasColumnType("float");

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

            builder.HasOne(e => e.CategoryInfo)
                .WithMany(pt => pt.TransactionInfos)
                .HasForeignKey(e => e.CategoryInfoId);

            builder.HasOne(e => e.ProductInfo)
                .WithMany(pt => pt.TransactionInfos)
                .HasForeignKey(e => e.ProductInfoId);

            builder.HasOne(e => e.ProductRateInfo)
                .WithMany(pt => pt.TransactionInfos)
                .HasForeignKey(e => e.ProductRateInfoId);

            builder.HasOne(e => e.UnitInfo)
                .WithMany(pt => pt.TransactionInfos)
                .HasForeignKey(e => e.UnitInfoId);

            builder.HasOne(e => e.Storeinfo)
                .WithMany(pt => pt.TransactionInfos)
                .HasForeignKey(e => e.StoreinfoId);

        }
    }
}
