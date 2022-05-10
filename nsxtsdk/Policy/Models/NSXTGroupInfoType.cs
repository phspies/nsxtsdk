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
    /// GroupInfo contains information about a particular Group used in Redirection Rules. It also contains information about
        /// policy path, if the group is created from Policy.
    /// </summary>
    [NSXTProperty(Description: @"GroupInfo contains information about a particular Group used in Redirection Rules. It also contains information about policy path, if the group is created from Policy.")]
    public class NSXTGroupInfoType 
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "group")]
        public NSXTResourceReferenceType Group { get; set; }
        /// <summary>
        /// Policy path of a particular Group.
        /// </summary>
        [JsonProperty(PropertyName = "group_policy_path")]
        public string? GroupPolicyPath { get; set; }
    }
}
