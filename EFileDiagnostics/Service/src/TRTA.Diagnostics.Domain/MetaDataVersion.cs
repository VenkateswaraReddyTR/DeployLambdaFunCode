using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRTA.Diagnostics.Domain
{
    public class MetaDataVersion
    {
        public MetaDataVersion()
        {
        }
        public virtual Guid Id { get; set; }
        public virtual int FileInfoId { get; set; }
        public virtual TaxAppYear TaxAppYear { get; set; }
        public virtual ReturnType ReturnType { get; set; }
        public virtual Jurisdiction Jurisdiction { get; set; }
        public virtual EfileSchemaType SchemaType { get; set; }
        public virtual DateTime DateModified { get; set; }
    }
}
