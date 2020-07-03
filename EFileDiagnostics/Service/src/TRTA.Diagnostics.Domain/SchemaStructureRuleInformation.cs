using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRTA.Diagnostics.Domain
{
    public class SchemaStructureRuleInformation
    {
        virtual public Guid Id { get; set; }
        virtual public string ReturnType { get; set; }
        virtual public string SchemaStructureSet { get; set; }
        virtual public string RulesInvolved { get; set; }
    }
}