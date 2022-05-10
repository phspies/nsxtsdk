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
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTVirtualNetworkInterfaceType : NSXTDiscoveredResourceType
    {
        /// <summary>
        /// MAC address of the virtual network interface.
        /// </summary>
        [JsonProperty(PropertyName = "mac_address", Required = Required.AllowNull)]
        public string MacAddress { get; set; }
        /// <summary>
        /// Owner virtual machine type; Edge, Service VM or other.
        /// </summary>
        [JsonProperty(PropertyName = "owner_vm_type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTVirtualNetworkInterfaceOwnerVmTypeEnumType? OwnerVmType { get; set; }
        /// <summary>
        /// Device key of the virtual network interface.
        /// </summary>
        [JsonProperty(PropertyName = "device_key", Required = Required.AllowNull)]
        public string DeviceKey { get; set; }
        /// <summary>
        /// Id of the host on which the vm exists.
        /// </summary>
        [JsonProperty(PropertyName = "host_id", Required = Required.AllowNull)]
        public string HostId { get; set; }
        /// <summary>
        /// Id of the vm to which this virtual network interface belongs.
        /// </summary>
        [JsonProperty(PropertyName = "owner_vm_id", Required = Required.AllowNull)]
        public string OwnerVmId { get; set; }
        /// <summary>
        /// Id of the vm unique within the host.
        /// </summary>
        [JsonProperty(PropertyName = "vm_local_id_on_host", Required = Required.AllowNull)]
        public string VmLocalIdOnHost { get; set; }
        /// <summary>
        /// External Id of the virtual network inferface.
        /// </summary>
        [JsonProperty(PropertyName = "external_id", Required = Required.AllowNull)]
        public string ExternalId { get; set; }
        /// <summary>
        /// LPort Attachment Id of the virtual network interface.
        /// </summary>
        [JsonProperty(PropertyName = "lport_attachment_id")]
        public string? LportAttachmentId { get; set; }
        /// <summary>
        /// IP Addresses of the the virtual network interface, from various sources.
        /// </summary>
        [JsonProperty(PropertyName = "ip_address_info")]
        public IList<NSXTIpAddressInfoType> IpAddressInfo { get; set; }
        /// <summary>
        /// Device name of the virtual network interface.
        /// </summary>
        [JsonProperty(PropertyName = "device_name")]
        public string? DeviceName { get; set; }
    }
}
