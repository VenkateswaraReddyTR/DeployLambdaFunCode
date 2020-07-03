using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TRTA.Diagnostics.Domain
{
    public class UserPreference
    {
        public UserPreference()
        {
        }
        public virtual string UserId { get; set; }
        public virtual string PreferenceJson { get; set; }
    }
}
