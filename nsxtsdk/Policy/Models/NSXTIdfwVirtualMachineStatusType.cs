// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using nsxtsdk.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using NJsonSchema.Converters;
using System.ComponentModel;

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
        [NSXTProperty(IsRequired: true, Description: @"Status of the Identity Firewall compute collection&apos;s Virtual Machine.")]
        [System.ComponentModel.DataAnnotations.Required]
        public IList<NSXTIdfwVirtualMachineConditionType> VmStatus { get; set; }
        /// <summary>
        /// VM ID of the VM on Identity Firewall compute collection.
        /// </summary>
        [JsonProperty(PropertyName = "vm_id", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"VM ID of the VM on Identity Firewall compute collection.")]
        [System.ComponentModel.DataAnnotations.Required]
        public string VmId { get; set; }
    }
}