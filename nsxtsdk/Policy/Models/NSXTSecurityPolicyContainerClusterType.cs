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
    public class NSXTSecurityPolicyContainerClusterType : NSXTPolicyConfigResourceType
    {
        /// <summary>
        /// Type of the container cluster where the security policy will be realized
        /// </summary>
        [JsonProperty(PropertyName = "container_cluster_type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTSecurityPolicyContainerClusterContainerClusterTypeEnumType? ContainerClusterType { get; set; }
        /// <summary>
        /// Path to the container cluster entity in NSX
        /// </summary>
        [JsonProperty(PropertyName = "container_cluster_path", Required = Required.AllowNull)]
        public string ContainerClusterPath { get; set; }
    }
}
