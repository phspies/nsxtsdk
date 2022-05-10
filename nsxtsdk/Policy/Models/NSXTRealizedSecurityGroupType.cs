using nsxtsdk.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.ComponentModel;
using NJsonSchema.Converters;
using Newtonsoft.Json.Converters;

namespace nsxtsdk.PolicyModels
{
    /// <summary>
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTRealizedSecurityGroupType : NSXTRealizedGroupType
    {
        /// <summary>
        /// Reference to the evaluted members of the Security Group.
        /// </summary>
        [JsonProperty(PropertyName = "evaluations")]
        public IList<NSXTRealizedSecurityGroupMemberEvaluationType> Evaluations { get; set; }
    }
}
