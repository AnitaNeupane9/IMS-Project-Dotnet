﻿                          using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.Models.Entity
{
    public class ProductInfo: BaseEntity
    {

        public int CategoryInfoId { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public int UnitInfoId {  get; set; }
        public int StoreinfoId { get; set; }
        public string ImageUrl { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }

        public virtual CategoryInfo CategoryInfo { get; set; }
        public virtual UnitInfo UnitInfo { get; set; }
        public virtual Storeinfo Storeinfo { get; set; }
        public virtual ICollection<ProductRateInfo> ProductRateInfos { get; set; }
        public virtual ICollection<TransactionInfo> TransactionInfos { get; set; }
        public virtual ICollection<StockInfo> StockInfos { get; set; }
    }

}
