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
    /// Service capabilities that will be inherited by service VMs created using a service definition that contains this service
        /// capability.
    /// </summary>
    [NSXTProperty(Description: @"Service capabilities that will be inherited by service VMs created using a service definition that contains this service capability.")]
    public class NSXTServiceCapabilityType 
    {
        public NSXTServiceCapabilityType()
        {
        }
        /// <summary>
        /// Indicating whether service supports NSH liveness detection.
        /// </summary>
        [JsonProperty(PropertyName = "nsh_liveness_support_enabled")]
        [NSXTProperty(IsRequired: false, Description: @"Indicating whether service supports NSH liveness detection.")]
        public bool? NshLivenessSupportEnabled { get; set; }
        /// <summary>
        /// Indicating whether service is configured to decrement SI field in NSH metadata.
        /// </summary>
        [JsonProperty(PropertyName = "can_decrement_si")]
        [NSXTProperty(IsRequired: false, Description: @"Indicating whether service is configured to decrement SI field in NSH metadata.")]
        public bool? CanDecrementSi { get; set; }
    }
}
