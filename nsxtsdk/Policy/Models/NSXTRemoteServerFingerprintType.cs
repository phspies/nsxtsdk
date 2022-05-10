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
    /// Remote server
    /// </summary>
    [NSXTProperty(Description: @"Remote server")]
    public class NSXTRemoteServerFingerprintType 
    {
        /// <summary>
        /// SSH fingerprint of server
        /// </summary>
        [JsonProperty(PropertyName = "ssh_fingerprint", Required = Required.AllowNull)]
        public string SshFingerprint { get; set; }
        /// <summary>
        /// Server port
        /// </summary>
        [JsonProperty(PropertyName = "port")]
        public long? Port { get; set; }
        /// <summary>
        /// Remote server hostname or IP address
        /// </summary>
        [JsonProperty(PropertyName = "server", Required = Required.AllowNull)]
        public string Server { get; set; }
    }
}
