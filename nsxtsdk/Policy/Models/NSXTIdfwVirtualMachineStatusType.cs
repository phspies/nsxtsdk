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
    /// ID and status of the VM on Identity Firewall compute collection.
    /// </summary>
    [NSXTProperty(Description: @"ID and status of the VM on Identity Firewall compute collection.")]
    public class NSXTIdfwVirtualMachineStatusType 
    {
        /// <summary>
        /// Status of the Identity Firewall compute collection's Virtual Machine.
        /// </summary>
        [JsonProperty(PropertyName = "vm_status", Required = Required.AllowNull)]
        public IList<NSXTIdfwVirtualMachineConditionType> VmStatus { get; set; }
        /// <summary>
        /// VM ID of the VM on Identity Firewall compute collection.
        /// </summary>
        [JsonProperty(PropertyName = "vm_id", Required = Required.AllowNull)]
        public string VmId { get; set; }
    }
}
