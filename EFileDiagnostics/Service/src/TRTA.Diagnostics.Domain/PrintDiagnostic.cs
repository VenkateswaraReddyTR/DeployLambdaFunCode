using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRTA.Diagnostics.Domain
{
    public class PrintDiagnostic
    {
        public PrintDiagnostic()
        {
        }

        public virtual Guid Id { get; set; }
        public virtual DateTime StartTime { get; set; }
        public virtual DateTime ?EndTime { get; set; }
        public virtual string Status { get; set; }
        public virtual string FileUrl { get; set; }
        public virtual string Locator { get; set; }
        public virtual string TaxAppYear { get; set; }
        public virtual string ReturnType { get; set; }
        public virtual string Filter { get; set; }
    }
}
