using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.Models.Entity
{
    public class StockInfo : BaseEntity
    {

        public int CategoryInfoId { get; set; }
        public int ProductInfoId { get; set; }
        public int productRateInfoId { get; set; }
        public float Quantity { get; set; }
        public int StoreinfoId { get; set; }

        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }

        public virtual CategoryInfo CategoryInfo { get; set; } 
        public virtual ProductInfo ProductInfo { get;set; }
        public virtual ProductRateInfo ProductRateInfo { get; set; }
        public virtual Storeinfo Storeinfo { get; set; }
    }
}
