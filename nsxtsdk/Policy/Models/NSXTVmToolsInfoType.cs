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
    public class NSXTVmToolsInfoType : NSXTDiscoveredResourceType
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "source")]
        public NSXTResourceReferenceType Source { get; set; }
        /// <summary>
        /// Type of VM - Edge, Service or other.
        /// </summary>
        [JsonProperty(PropertyName = "vm_type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTVmToolsInfoVmTypeEnumType? VmType { get; set; }
        /// <summary>
        /// Id of the VM which is assigned locally by the host. It is the VM-moref on ESXi hosts, in other environments it is VM
        /// UUID.
        /// </summary>
        [JsonProperty(PropertyName = "host_local_id")]
        public string? HostLocalId { get; set; }
        /// <summary>
        /// Version of network agent on the VM of a third party partner solution.
        /// </summary>
        [JsonProperty(PropertyName = "network_agent_version")]
        public string? NetworkAgentVersion { get; set; }
        /// <summary>
        /// Version of file agent on the VM of a third party partner solution.
        /// </summary>
        [JsonProperty(PropertyName = "file_agent_version")]
        public string? FileAgentVersion { get; set; }
        /// <summary>
        /// Current external id of this virtual machine in the system.
        /// </summary>
        [JsonProperty(PropertyName = "external_id")]
        public string? ExternalId { get; set; }
        /// <summary>
        /// Version of VMTools installed on the VM.
        /// </summary>
        [JsonProperty(PropertyName = "tools_version")]
        public string? ToolsVersion { get; set; }
        /// <summary>
        /// Endpoint Protection (Third party AV partner using NXGI) status on the VM. TRUE  - VM is configured and protected by EPP
        /// Service VM. FALSE - VM is either not configured for protection or VM is disconnected from EPP Service VM.
        /// </summary>
        [JsonProperty(PropertyName = "svm_connectivity")]
        public bool? SvmConnectivity { get; set; }
        /// <summary>
        /// Connectivity Status between each Guest Introspection Solution deployed in the data center with the guest VM.
        /// </summary>
        [JsonProperty(PropertyName = "svmStatus")]
        public IList<NSXTSvmConnectivityStatusType> SvmStatus { get; set; }
    }
}
