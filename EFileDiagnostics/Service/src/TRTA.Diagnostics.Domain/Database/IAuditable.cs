using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRTA.Diagnostics.Domain.Database
{
    public interface IAuditable
    {
        DateTime DateOfCreation { get; set; }
        DateTime DateModified { get; set; }
        // string ModifiedBy { get; set; }
    }
}
