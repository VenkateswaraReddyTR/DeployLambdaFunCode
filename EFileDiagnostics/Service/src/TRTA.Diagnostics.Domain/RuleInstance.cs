using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using TRTA.Diagnostics.Domain.Database;

namespace TRTA.Diagnostics.Domain
{
    public class RuleInstance 
    {
        public virtual Guid Id { get; set; }
        public virtual string InstanceName { get; set; }
        public virtual int QueueSize { get; set; }
        public virtual bool Active { get; set; }
    }
}
