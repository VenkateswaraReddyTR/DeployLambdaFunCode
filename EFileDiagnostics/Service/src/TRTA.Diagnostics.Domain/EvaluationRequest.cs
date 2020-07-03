using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using TRTA.Diagnostics.Domain.Database;

namespace TRTA.Diagnostics.Domain
{
    public class EvaluationRequest : IAuditable
    {
        public virtual int Id { get; set; }
        public virtual string TaxAppYear { get; set; }
        public virtual string ReturnType { get; set; }
        public virtual string Jurisdiction { get; set; }
        public virtual string Locator { get; set; }
        public virtual string SchemaType { get; set; }
        public virtual Int64 FileSize { get; set; }
        [IgnoreDataMember]
        public virtual string DocumentToEvaluate { get; set; }

        public virtual string RequestStatus { get; set; }
        public virtual DateTime DateOfCreation { get; set; }
        public virtual DateTime DateModified { get; set; }
        public virtual string InstanceName { get; set; }
        public virtual string RequestedBy { get; set; }
    }
}
