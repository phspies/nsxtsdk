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
    public class NSXTClusterMemberDetailsType 
    {
        /// <summary>
        /// The Antrea cluster name of the pod
        /// </summary>
        [JsonProperty(PropertyName = "cluster_name")]
        public string? ClusterName { get; set; }
        /// <summary>
        /// The Antrea cluster id of the pod
        /// </summary>
        [JsonProperty(PropertyName = "cluster_id")]
        public string? ClusterId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "namespaces", Required = Required.AllowNull)]
        public IList<NSXTNamespaceMemberDetailsType> Namespaces { get; set; }
    }
}
