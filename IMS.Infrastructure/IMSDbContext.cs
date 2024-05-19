using IMS.Infrastructure.Entity_Configuration;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace IMS.Infrastructure
{
    public class IMSDbContext: DbContext
    {
        public IMSDbContext(DbContextOptions<IMSDbContext> Options) 
            : base(Options)
        {
                
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {

            //Builder.ApplyConfiguration(new StoreConfiguration());
            //rakhda dependency anusar rahne jastaii ... store info aru sanga dependend xaina but aru chai yo sanga dependent xa
            //so yeslaii agadhi rakhn painxa
            builder.ApplyConfiguration(new StoreConfiguration());
            builder.ApplyConfiguration(new Categoryinfoconfiguration());
            builder.ApplyConfiguration(new CustomerInfoConfiguration());
            builder.ApplyConfiguration(new UnitInfoConfiguration());
            builder.ApplyConfiguration(new ProductInfoConfiguration());
            builder.ApplyConfiguration(new RackInfoConfiguration());
            builder.ApplyConfiguration(new SupplierInfoConfiguration());
            builder.ApplyConfiguration(new ProductRateInfoConfiguration());
            builder.ApplyConfiguration(new StockInfoConfiguration());
            builder.ApplyConfiguration(new TransactionInfoconfiguration());
            builder.ApplyConfiguration(new ProductInvoiceInfoConfiguration());
            builder.ApplyConfiguration(new ProductInvoiceDetailInfoConfiguration());


        }
    }
}







//DbContext use garne vaye .Tools wala package install garnu prxa