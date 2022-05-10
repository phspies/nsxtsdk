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
    /// Status of the Identity Firewall compute collection's VM.
    /// </summary>
    [NSXTProperty(Description: @"Status of the Identity Firewall compute collection&apos;s VM.")]
    public class NSXTIdfwVirtualMachineConditionType 
    {
        /// <summary>
        /// VM IDFW Status.
        /// </summary>
        [JsonProperty(PropertyName = "status", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTIdfwVirtualMachineConditionStatusEnumType Status { get; set; }
        /// <summary>
        /// IDFW compute collection's VM condition.
        /// </summary>
        [JsonProperty(PropertyName = "status_detail")]
        public string? StatusDetail { get; set; }
    }
}
