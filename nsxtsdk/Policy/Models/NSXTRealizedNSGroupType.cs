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
    public class NSXTRealizedNSGroupType : NSXTRealizedGroupType
    {
        /// <summary>
        /// Reference to the evaluated members of the NSGroup.
        /// </summary>
        [JsonProperty(PropertyName = "evaluations")]
        public IList<NSXTRealizedNSGroupMemberEvaluationType> Evaluations { get; set; }
    }
}
