using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRTA.Diagnostics.Domain
{
    public class PlatformDiagnosticsResponse
    {
        public PlatformDiagnosticsResponse()
        {
        }
        
        public virtual string ReturnType { get; set; }
        public virtual string Jurisdiction { get; set; }
        public virtual string TaxAppYear { get; set; }
        public virtual DateTime StartDate { get; set; }
        public virtual DateTime? EndDate { get; set; }
        public virtual string Status { get; set; }
        public virtual string SchemaType { get; set; }
        public virtual List<PlatformExecutionLog> ExecutionLogs { get; set; }
        public virtual Int64 FileSize { get; set; }
    }
}
