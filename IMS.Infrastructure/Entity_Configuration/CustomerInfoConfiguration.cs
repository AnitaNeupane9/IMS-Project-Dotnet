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
    public class CustomerInfoConfiguration : IEntityTypeConfiguration<CustomerInfo>
    {
        public void Configure(EntityTypeBuilder<CustomerInfo> builder)
        {
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id)
                .ValueGeneratedOnAdd();


            builder.Property(e => e.CustomerName)
                .HasMaxLength(100)
                .IsUnicode(true);


            builder.Property(e => e.CustomerEmail)
                .HasMaxLength(100)
                .IsUnicode(true);

            builder.Property(e => e.PhoneNumber)
                .HasMaxLength(20)
                .IsUnicode(true);

            builder.Property(e => e.Address)
                .HasMaxLength(100)
                .IsUnicode(true);


            builder.Property(e => e.PanNo)
                .HasMaxLength(50)
                .IsUnicode(true);


            builder.HasOne(e => e.Storeinfo)
                .WithMany(pt => pt.CustomerInfos)
                .HasForeignKey(e => e.StoreinfoId);


            builder.HasMany(e => e.ProductInvoiceInfos)
                .WithOne(pt => pt.CustomerInfo)
                .HasForeignKey(e => e.CustomerInfoId);


            builder.Property(e => e.CreatedDate)
               .HasDefaultValueSql("GETDATE()");


            builder.Property(e => e.CreatedBy)
                //.IsRequired()
                .IsUnicode(true);
        }
    }
}
