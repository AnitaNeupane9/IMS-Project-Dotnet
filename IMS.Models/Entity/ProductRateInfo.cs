﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.Models.Entity
{
    public class ProductRateInfo : BaseEntity
    {
        public int CategoryInfoId { get; set; }
        public int ProductInfoId { get; set;}
        public int StoreinfoId { get; set; }
        public int SupplierInfoId { get; set; }
        public int RackInfoId { get; set; }

        public float CostPrice { get; set; }
        public float SellingPrice { get; set; }
        public float Quantity { get; set; }
        public float SoldQuantity { get; set; }
        public float RemainingQuantity { get; set; }
        public string BatchNo { get; set; }
        public DateTime PurchaseDate { get; set; }
        public DateTime? ExpiryDate { get; set; }

        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }

        public virtual CategoryInfo CategoryInfo { get; set; }
        public virtual ProductInfo ProductInfo { get; set; }
        public virtual Storeinfo Storeinfo { get; set; }
        public virtual SupplierInfo SupplierInfo { get; set; }
        public virtual RackInfo RackInfo { get; set; }
        public virtual ICollection<ProductInvoiceDetailInfo> ProductInvoiceDetailInfos { get; set; }
        public virtual ICollection<TransactionInfo> TransactionInfos { get; set; }
        public virtual ICollection<StockInfo> StockInfos { get; set; }
    }
}
