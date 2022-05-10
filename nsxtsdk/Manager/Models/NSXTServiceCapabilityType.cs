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
    /// Service capabilities that will be inherited by service VMs created using a service definition that contains this service
        /// capability.
    /// </summary>
    [NSXTProperty(Description: @"Service capabilities that will be inherited by service VMs created using a service definition that contains this service capability.")]
    public class NSXTServiceCapabilityType 
    {
        /// <summary>
        /// Indicating whether service supports NSH liveness detection.
        /// </summary>
        [JsonProperty(PropertyName = "nsh_liveness_support_enabled")]
        public bool? NshLivenessSupportEnabled { get; set; }
        /// <summary>
        /// Indicating whether service is configured to decrement SI field in NSH metadata.
        /// </summary>
        [JsonProperty(PropertyName = "can_decrement_si")]
        public bool? CanDecrementSi { get; set; }
    }
}
