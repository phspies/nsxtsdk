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
    /// Napp cluster form factor
    /// </summary>
    [NSXTProperty(Description: @"Napp cluster form factor")]
    public class NSXTIntelligenceFormFactorType 
    {
        /// <summary>
        /// Number of virtual cpus on the Napp worker nodes
        /// </summary>
        [JsonProperty(PropertyName = "vcpu")]
        public long? Vcpu { get; set; }
        /// <summary>
        /// Default number of Napp worker nodes.
        /// </summary>
        [JsonProperty(PropertyName = "default_worker_count")]
        public long? DefaultWorkerCount { get; set; }
        /// <summary>
        /// Disk size of the Napp worker nodes in GBs.
        /// </summary>
        [JsonProperty(PropertyName = "disk")]
        public long? Disk { get; set; }
        /// <summary>
        /// NSX Intelligence node form factor type
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTIntelligenceFormFactorTypeEnumType? Type { get; set; }
        /// <summary>
        /// Memory size of the Napp worker nodes in GBs
        /// </summary>
        [JsonProperty(PropertyName = "memory")]
        public long? Memory { get; set; }
    }
}
