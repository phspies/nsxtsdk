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
    /// Required node resources to deploy a form factor
    /// </summary>
    [NSXTProperty(Description: @"Required node resources to deploy a form factor")]
    public class NSXTNodeResourcesType 
    {
        /// <summary>
        /// Required number of worker nodes.
        /// </summary>
        [JsonProperty(PropertyName = "number_of_worker_nodes")]
        public long? NumberOfWorkerNodes { get; set; }
        /// <summary>
        /// Memore required to deploy a form factor.
        /// </summary>
        [JsonProperty(PropertyName = "ram")]
        public long? Ram { get; set; }
        /// <summary>
        /// Transient storage required to deploy a form factor.
        /// </summary>
        [JsonProperty(PropertyName = "ephemeral_storage")]
        public long? EphemeralStorage { get; set; }
        /// <summary>
        /// Disk required to deploy a form factor.
        /// </summary>
        [JsonProperty(PropertyName = "disk")]
        public long? Disk { get; set; }
        /// <summary>
        /// Required number of master nodes.
        /// </summary>
        [JsonProperty(PropertyName = "number_of_master_nodes")]
        public long? NumberOfMasterNodes { get; set; }
        /// <summary>
        /// Number of CPU cores required to deploy a form factor.
        /// </summary>
        [JsonProperty(PropertyName = "cpu")]
        public long? Cpu { get; set; }
    }
}
