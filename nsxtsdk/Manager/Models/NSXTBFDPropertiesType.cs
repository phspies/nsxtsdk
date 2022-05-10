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
    /// BFD information
    /// </summary>
    [NSXTProperty(Description: @"BFD information")]
    public class NSXTBFDPropertiesType 
    {
        /// <summary>
        /// True if tunnel is active in a gateway HA setup
        /// </summary>
        [JsonProperty(PropertyName = "active")]
        public bool? Active { get; set; }
        /// <summary>
        /// State of the BFD session
        /// </summary>
        [JsonProperty(PropertyName = "state")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTBfdpropertiesStateEnumType? State { get; set; }
        /// <summary>
        /// State of the remote interface's BFD session
        /// </summary>
        [JsonProperty(PropertyName = "remote_state")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTBfdpropertiesRemoteStateEnumType? RemoteState { get; set; }
        /// <summary>
        /// A short message indicating what the remote interface's BFD session thinks is wrong in case of a problem
        /// </summary>
        [JsonProperty(PropertyName = "remote_diagnostic")]
        public string? RemoteDiagnostic { get; set; }
        /// <summary>
        /// True if the BFD session believes this interface may be used to forward traffic
        /// </summary>
        [JsonProperty(PropertyName = "forwarding")]
        public bool? Forwarding { get; set; }
        /// <summary>
        /// A short message indicating what the BFD session thinks is wrong in case of a problem
        /// </summary>
        [JsonProperty(PropertyName = "diagnostic")]
        public string? Diagnostic { get; set; }
    }
}
