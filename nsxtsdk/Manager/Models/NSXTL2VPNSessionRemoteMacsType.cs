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
    /// Remote MAC addresses for all logical switches for a L2VPN session.
    /// </summary>
    [NSXTProperty(Description: @"Remote MAC addresses for all logical switches for a L2VPN session.")]
    public class NSXTL2VPNSessionRemoteMacsType 
    {
        /// <summary>
        /// List MAC addresses for all logical switch for a particular L2VPN session.
        /// </summary>
        [JsonProperty(PropertyName = "remote_mac_addresses")]
        public IList<NSXTL2VPNSessionRemoteMacsForLSType> RemoteMacAddresses { get; set; }
        /// <summary>
        /// L2VPN display name.
        /// </summary>
        [JsonProperty(PropertyName = "display_name")]
        public string? DisplayName { get; set; }
        /// <summary>
        /// L2VPN session identifier.
        /// </summary>
        [JsonProperty(PropertyName = "session_id")]
        public string? SessionId { get; set; }
    }
}
