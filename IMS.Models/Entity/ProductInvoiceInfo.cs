﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.Models.Entity
{
    public class ProductInvoiceInfo: BaseEntity
    {

        //public Guid Id { get; set; }
        public int PaymentMethod { get; set; }
        public string InvoiceNo { get; set; }
        public int StoreinfoId { get; set; }
        public int  CustomerInfoId { get; set; }
        public DateTime TransactionDate { get; set; }
        public float NetAmount { get; set; }
        public float DiscountAmount { get; set; }
        public float TotalAmount { get; set; }
        //public double Tax { get; set; }
        //public double VAT { get; set; }
        public string Remarks { get; set; }
        public int BillStatus { get; set; }
        public string CancellationRemarks { get; set; }


        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }

        public virtual ICollection<ProductInvoiceDetailInfo> ProductInvoiceDetailInfos { get; set; }
        public virtual CustomerInfo CustomerInfo { get; set; }
        public virtual Storeinfo Storeinfo { get; set; }
    }
}
