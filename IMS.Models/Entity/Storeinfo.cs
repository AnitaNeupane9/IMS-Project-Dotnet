using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.Models.Entity
{
    public class Storeinfo: BaseEntity
    {
        //Data Anotations le data validation herxa

        [Required]
        [Display(Name = "Store Name")]
        public string StoreName { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^9\d{9}$", ErrorMessage = "Entered phone format is not valid.")]
        public string PhoneNumber { get; set; }
        [Required]
        public string RegistrationNumber { get; set; }
        [Required]
        public string PanNo { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }


        public virtual ICollection<CategoryInfo> CategoryInfos { get; set; }
        //IEnumerable<T>: Best for forward-only iteration, read-only access, and deferred execution with LINQ.
        //ICollection<T>: Best for collections that require modification, counting elements, and more comprehensive collection operations.

        public virtual ICollection<CustomerInfo> CustomerInfos { get; set; }
        public virtual ICollection<ProductInfo> ProductInfos { get; set; }
        public virtual ICollection<ProductInvoiceInfo> ProductInvoiceInfos { get; set; }
        public virtual ICollection<ProductRateInfo> ProductRateInfos { get; set; }
        public virtual ICollection<RackInfo> RackInfos { get; set; }
        public virtual ICollection<TransactionInfo> TransactionInfos { get; set; }
        public virtual ICollection<StockInfo> StockInfos { get; set; }
        public virtual ICollection<SupplierInfo> SuppliersInfos { get; set; }
    }
}
