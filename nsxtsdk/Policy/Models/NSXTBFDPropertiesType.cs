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
    /// BFD information
    /// </summary>
    [NSXTProperty(Description: @"BFD information")]
    public class NSXTBFDPropertiesType 
    {
        public NSXTBFDPropertiesType()
        {
        }
        /// <summary>
        /// True if tunnel is active in a gateway HA setup
        /// </summary>
        [JsonProperty(PropertyName = "active")]
        [NSXTProperty(IsRequired: false, Description: @"True if tunnel is active in a gateway HA setup")]
        public bool? Active { get; set; }
        /// <summary>
        /// State of the BFD session
        /// </summary>
        [JsonProperty(PropertyName = "state")]
        [NSXTProperty(IsRequired: false, Description: @"State of the BFD session")]
        public NSXTBfdpropertiesStateEnumType? State { get; set; }
        /// <summary>
        /// State of the remote interface's BFD session
        /// </summary>
        [JsonProperty(PropertyName = "remote_state")]
        [NSXTProperty(IsRequired: false, Description: @"State of the remote interface&apos;s BFD session")]
        public NSXTBfdpropertiesRemoteStateEnumType? RemoteState { get; set; }
        /// <summary>
        /// A short message indicating what the remote interface's BFD session thinks is wrong in case of a problem
        /// </summary>
        [JsonProperty(PropertyName = "remote_diagnostic")]
        [NSXTProperty(IsRequired: false, Description: @"A short message indicating what the remote interface&apos;s BFD session thinks is wrong in case of a problem")]
        public string? RemoteDiagnostic { get; set; }
        /// <summary>
        /// True if the BFD session believes this interface may be used to forward traffic
        /// </summary>
        [JsonProperty(PropertyName = "forwarding")]
        [NSXTProperty(IsRequired: false, Description: @"True if the BFD session believes this interface may be used to forward traffic")]
        public bool? Forwarding { get; set; }
        /// <summary>
        /// A short message indicating what the BFD session thinks is wrong in case of a problem
        /// </summary>
        [JsonProperty(PropertyName = "diagnostic")]
        [NSXTProperty(IsRequired: false, Description: @"A short message indicating what the BFD session thinks is wrong in case of a problem")]
        public string? Diagnostic { get; set; }
    }
}
