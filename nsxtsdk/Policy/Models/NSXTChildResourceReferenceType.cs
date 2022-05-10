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
    public class NSXTChildResourceReferenceType : NSXTChildPolicyConfigResourceType
    {
        /// <summary>
        /// subtree for this type within policy tree containing nested elements.
        /// </summary>
        [JsonProperty(PropertyName = "children")]
        public IList<NSXTChildPolicyConfigResourceType> Children { get; set; }
        /// <summary>
        /// The target type of this reference
        /// </summary>
        [JsonProperty(PropertyName = "target_type", Required = Required.AllowNull)]
        public string TargetType { get; set; }
    }
}
