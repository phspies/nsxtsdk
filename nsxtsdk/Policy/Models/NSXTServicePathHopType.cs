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
    /// Represents a service VM implementing a particular service in a service chain
    /// </summary>
    [NSXTProperty(Description: @"Represents a service VM implementing a particular service in a service chain")]
    public class NSXTServicePathHopType 
    {
        /// <summary>
        /// Indicating whether the corresponding service VM is active or not per DP.
        /// </summary>
        [JsonProperty(PropertyName = "is_active_from_dp")]
        public bool? IsActiveFromDp { get; set; }
        /// <summary>
        /// Indicating whether the corresponding service VM is active or not per MP.
        /// </summary>
        [JsonProperty(PropertyName = "is_active_from_mp")]
        public bool? IsActiveFromMp { get; set; }
        /// <summary>
        /// ID of the virtual network interface.
        /// </summary>
        [JsonProperty(PropertyName = "vif")]
        public string? Vif { get; set; }
        /// <summary>
        /// MAC address of the virtual network interface.
        /// </summary>
        [JsonProperty(PropertyName = "mac_address")]
        public string? MacAddress { get; set; }
        /// <summary>
        /// Action that will be taken by the corresponding service VM of the hop.
        /// </summary>
        [JsonProperty(PropertyName = "action")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTServicePathHopActionEnumType? Action { get; set; }
        /// <summary>
        /// Indicating whether the corresponding service VM is active or not per CCP.
        /// </summary>
        [JsonProperty(PropertyName = "is_active_from_ccp")]
        public bool? IsActiveFromCcp { get; set; }
        /// <summary>
        /// Indicating the maintenance mode of the corresponding service VM.
        /// </summary>
        [JsonProperty(PropertyName = "in_maintenance_mode")]
        public bool? InMaintenanceMode { get; set; }
        /// <summary>
        /// Indicating whether NSH liveness is supported or not by the corresponding service VM.
        /// </summary>
        [JsonProperty(PropertyName = "nsh_liveness_support")]
        public bool? NshLivenessSupport { get; set; }
        /// <summary>
        /// Indicating whether service is configured to decrement SI field in NSH metadata.
        /// </summary>
        [JsonProperty(PropertyName = "can_decrement_si")]
        public bool? CanDecrementSi { get; set; }
    }
}
