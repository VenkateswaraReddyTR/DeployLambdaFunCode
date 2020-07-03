using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRTA.Diagnostics.Domain
{
    public class PlatformCategoryType
    {
        
        public PlatformCategoryType()
        {
           
        }
        public virtual string CategoryName { get; set; }
        public virtual string TypeValue { get; set; }
    }
}