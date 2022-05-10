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
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTSupportBundleFileTransferProtocolType 
    {
        /// <summary>
        /// SSH fingerprint of server
        /// </summary>
        [JsonProperty(PropertyName = "ssh_fingerprint", Required = Required.AllowNull)]
        public string SshFingerprint { get; set; }
        /// <summary>
        /// Protocol name
        /// </summary>
        [JsonProperty(PropertyName = "name", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTSupportBundleFileTransferProtocolNameEnumType Name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "authentication_scheme", Required = Required.AllowNull)]
        public NSXTSupportBundleFileTransferAuthenticationSchemeType AuthenticationScheme { get; set; }
    }
}
