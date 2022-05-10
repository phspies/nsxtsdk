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
    /// Details of the member belonging to a Group
    /// </summary>
    [NSXTProperty(Description: @"Details of the member belonging to a Group")]
    public class NSXTNamespaceMemberDetailsType 
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "pods", Required = Required.AllowNull)]
        public IList<NSXTPolicyGroupMemberDetailsType> Pods { get; set; }
        /// <summary>
        /// The display name of the member on the enforcement point
        /// </summary>
        [JsonProperty(PropertyName = "display_name")]
        public string? DisplayName { get; set; }
        /// <summary>
        /// The ID of the member on the enforcement point
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string? Id { get; set; }
    }
}
