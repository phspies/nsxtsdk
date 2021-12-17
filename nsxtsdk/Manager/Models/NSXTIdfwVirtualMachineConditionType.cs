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

namespace nsxtsdk.ManagerModels
{
    /// <summary>
    /// Status of the Identity Firewall compute collection's VM.
    /// </summary>
    [NSXTProperty(Description: @"Status of the Identity Firewall compute collection&apos;s VM.")]
    public class NSXTIdfwVirtualMachineConditionType 
    {
        public NSXTIdfwVirtualMachineConditionType()
        {
        }
        /// <summary>
        /// VM IDFW Status.
        /// </summary>
        [JsonProperty(PropertyName = "status", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"VM IDFW Status.")]
        [System.ComponentModel.DataAnnotations.Required]
        public NSXTIdfwVirtualMachineConditionStatusEnumType Status { get; set; }
        /// <summary>
        /// IDFW compute collection's VM condition.
        /// </summary>
        [JsonProperty(PropertyName = "status_detail")]
        [NSXTProperty(IsRequired: false, Description: @"IDFW compute collection&apos;s VM condition.")]
        public string? StatusDetail { get; set; }
    }
}
