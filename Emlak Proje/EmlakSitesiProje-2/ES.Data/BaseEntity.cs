using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ES.Data
{
    public class BaseEntity
    {  
        
        public System.DateTime? UpdateDate { get; set; }
        public System.DateTime? DeleteDate { get; set; }
        public System.DateTime? CreateDate { get; set; }
        public bool? isDeleted { get; set; }

    }
}
