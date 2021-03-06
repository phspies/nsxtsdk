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
    public class NSXTVirtualMachineType : NSXTDiscoveredResourceType
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "source")]
        public NSXTResourceReferenceType Source { get; set; }
        /// <summary>
        /// Id of the vm unique within the host.
        /// </summary>
        [JsonProperty(PropertyName = "local_id_on_host", Required = Required.AllowNull)]
        public string LocalIdOnHost { get; set; }
        /// <summary>
        /// Virtual Machine type; Edge, Service VM or other.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTVirtualMachineTypeEnumType? Type { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "guest_info")]
        public NSXTGuestInfoType GuestInfo { get; set; }
        /// <summary>
        /// Current power state of this virtual machine in the system.
        /// </summary>
        [JsonProperty(PropertyName = "power_state", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTVirtualMachinePowerStateEnumType PowerState { get; set; }
        /// <summary>
        /// List of external compute ids of the virtual machine in the format 'id-type-key:value' , list of external compute ids
        /// ['uuid:xxxx-xxxx-xxxx-xxxx', 'moIdOnHost:moref-11', 'instanceUuid:xxxx-xxxx-xxxx-xxxx']
        /// </summary>
        [JsonProperty(PropertyName = "compute_ids", Required = Required.AllowNull)]
        public IList<string> ComputeIds { get; set; }
        /// <summary>
        /// Id of the host in which this virtual machine exists.
        /// </summary>
        [JsonProperty(PropertyName = "host_id")]
        public string? HostId { get; set; }
        /// <summary>
        /// Current external id of this virtual machine in the system.
        /// </summary>
        [JsonProperty(PropertyName = "external_id", Required = Required.AllowNull)]
        public string ExternalId { get; set; }
    }
}
