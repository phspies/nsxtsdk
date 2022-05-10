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
    public class NSXTRealizedVirtualMachineType : NSXTPolicyRealizedResourceType
    {
        /// <summary>
        /// Id of the host on which the vm exists.
        /// </summary>
        [JsonProperty(PropertyName = "host_id")]
        public string? HostId { get; set; }
        /// <summary>
        /// Id of the vm unique within the host.
        /// </summary>
        [JsonProperty(PropertyName = "local_id_on_host")]
        public string? LocalIdOnHost { get; set; }
        /// <summary>
        /// Current power state of this virtual machine in the system.
        /// </summary>
        [JsonProperty(PropertyName = "power_state")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTRealizedVirtualMachinePowerStateEnumType? PowerState { get; set; }
        /// <summary>
        /// List of external compute ids of the virtual machine in the format 'id-type-key:value' , list of external compute ids
        /// ['uuid:xxxx-xxxx-xxxx-xxxx', 'moIdOnHost:moref-11', 'instanceUuid:xxxx-xxxx-xxxx-xxxx']
        /// </summary>
        [JsonProperty(PropertyName = "compute_ids")]
        public IList<string> ComputeIds { get; set; }
    }
}
