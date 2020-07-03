using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TRTA.Diagnostics.Domain
{
    public class VersionInfo
    {
        public VersionInfo()
        {
        }
        public virtual int Version { get; set; }
        public virtual string Description { get; set; }
        public virtual DateTime AppliedOn { get; set; }

        public const int RequiredDbVersion = 68;
    }
}
