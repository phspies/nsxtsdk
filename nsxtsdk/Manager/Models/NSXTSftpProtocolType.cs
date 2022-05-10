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
    public class NSXTSftpProtocolType : NSXTProtocolType
    {
        /// <summary>
        /// SSH fingerprint of server
        /// </summary>
        [JsonProperty(PropertyName = "ssh_fingerprint", Required = Required.AllowNull)]
        public string SshFingerprint { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "authentication_scheme", Required = Required.AllowNull)]
        public NSXTPasswordAuthenticationSchemeType AuthenticationScheme { get; set; }
    }
}
