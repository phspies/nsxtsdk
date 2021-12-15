// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using nsxtsdk.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using NJsonSchema.Converters;
using System.ComponentModel;

namespace nsxtsdk.PolicyModels
{
    /// <summary>
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTIdsSecurityPolicyType : NSXTPolicyType
    {
        /// <summary>
        /// IDS Rules that are a part of this SecurityPolicy
        /// </summary>
        [JsonProperty(PropertyName = "rules")]
        [NSXTProperty(IsRequired: false, Description: @"IDS Rules that are a part of this SecurityPolicy")]
        public IList<NSXTIdsRuleType> Rules { get; set; }
    }
}