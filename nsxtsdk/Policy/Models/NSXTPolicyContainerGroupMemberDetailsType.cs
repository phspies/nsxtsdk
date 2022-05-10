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
    public class NSXTPolicyContainerGroupMemberDetailsType 
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "cluster", Required = Required.AllowNull)]
        public IList<NSXTClusterMemberDetailsType> Cluster { get; set; }
    }
}
