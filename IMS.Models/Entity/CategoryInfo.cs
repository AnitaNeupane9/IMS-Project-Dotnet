using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.Models.Entity
{
    public class CategoryInfo : BaseEntity
    {
        public string CategoryName { get; set; }
        public string CategoryDescription { get; set; }
        public int StoreinfoId { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }

        public virtual Storeinfo Storeinfo { get; set; }
        //function becomes lazy loading by using  this virtual function 
        //There are two types of loading: eager and lazy

        public virtual ICollection<ProductInfo> ProductInfos { get; set; }
        public virtual ICollection<ProductRateInfo> ProductRateInfos { get; set; }
        public virtual ICollection<TransactionInfo> TransactionInfos { get; set; }
        public virtual ICollection<StockInfo> StockInfos { get; set; }

    }
}
