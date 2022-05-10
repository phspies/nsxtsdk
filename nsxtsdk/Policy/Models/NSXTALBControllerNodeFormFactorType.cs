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
    /// Advanced Load Balancer node form factor.
    /// </summary>
    [NSXTProperty(Description: @"Advanced Load Balancer node form factor.")]
    public class NSXTALBControllerNodeFormFactorType 
    {
        /// <summary>
        /// Number of virtual cpus on the Advanced Load Balancer controller node.
        /// </summary>
        [JsonProperty(PropertyName = "vcpu")]
        public long? Vcpu { get; set; }
        /// <summary>
        /// Disk size of the Advanced Load Balancer controller node in Bytes.
        /// </summary>
        [JsonProperty(PropertyName = "disk")]
        public long? Disk { get; set; }
        /// <summary>
        /// Advanced Load Balancer controller node form factor type.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTAlbcontrollerNodeFormFactorTypeEnumType? Type { get; set; }
        /// <summary>
        /// Memory size of the Advanced Load Balancer controller node in Bytes.
        /// </summary>
        [JsonProperty(PropertyName = "memory")]
        public long? Memory { get; set; }
    }
}
