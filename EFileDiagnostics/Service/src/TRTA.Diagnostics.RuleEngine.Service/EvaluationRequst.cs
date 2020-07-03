using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TRTA.Diagnostics.RuleEngine.Service
{
    [ModelBinder(typeof(FileDataModelBinder), Name = "evaluationRequest")]
    public class EvaluationRequest
    {
        public virtual string TaxAppYear { get; set; }
        public virtual string ReturnType { get; set; }
        public virtual string Jurisdiction { get; set; }
        public virtual string Locator { get; set; }
        public virtual string SchemaType { get; set; }
    }
}
