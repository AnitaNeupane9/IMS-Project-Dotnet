﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.Models.Entity
{
    public class RackInfo: BaseEntity
    {
        public string RackName { get; set; }
        public int StoreinfoId { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }

        public virtual Storeinfo Storeinfo { get; set; }
        public virtual ICollection<ProductRateInfo> ProductRateInfos { get; set; }
    }
}
