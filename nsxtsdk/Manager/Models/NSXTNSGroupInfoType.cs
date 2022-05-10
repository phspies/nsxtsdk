using nsxtsdk.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.ComponentModel;
using NJsonSchema.Converters;
using Newtonsoft.Json.Converters;

namespace nsxtsdk.ManagerModels
{
    /// <summary>
    /// NSGroupInfo contains information about a particular NSGroup used in a SI Rule. It also contains information about policy
        /// path used to create this NSGroup.
    /// </summary>
    [NSXTProperty(Description: @"NSGroupInfo contains information about a particular NSGroup used in a SI Rule. It also contains information about policy path used to create this NSGroup.")]
    public class NSXTNSGroupInfoType 
    {
        /// <summary>
        /// Relative Policy path of a particular NSGroup.
        /// </summary>
        [JsonProperty(PropertyName = "nsgroup_policy_path")]
        public string? NsgroupPolicyPath { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "nsgroup")]
        public NSXTResourceReferenceType Nsgroup { get; set; }
    }
}
