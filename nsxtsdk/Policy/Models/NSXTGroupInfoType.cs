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
    /// GroupInfo contains information about a particular Group used in Redirection Rules. It also contains information about
        /// policy path, if the group is created from Policy.
    /// </summary>
    [NSXTProperty(Description: @"GroupInfo contains information about a particular Group used in Redirection Rules. It also contains information about policy path, if the group is created from Policy.")]
    public class NSXTGroupInfoType 
    {
        /// <summary>
        /// Group Data.
        /// </summary>
        [JsonProperty(PropertyName = "group")]
        [NSXTProperty(IsRequired: false, Description: @"Group Data.")]
        public NSXTResourceReferenceType Group { get; set; }
        /// <summary>
        /// Policy path of a particular Group.
        /// </summary>
        [JsonProperty(PropertyName = "group_policy_path")]
        [NSXTProperty(IsRequired: false, Description: @"Policy path of a particular Group.")]
        public string? GroupPolicyPath { get; set; }
    }
}
