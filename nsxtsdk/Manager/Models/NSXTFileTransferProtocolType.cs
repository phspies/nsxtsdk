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
    /// Protocol to transfer backup file to remote server
    /// </summary>
    [NSXTProperty(Description: @"Protocol to transfer backup file to remote server")]
    public class NSXTFileTransferProtocolType 
    {
        /// <summary>
        /// Protocol name
        /// </summary>
        [JsonProperty(PropertyName = "protocol_name", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTFileTransferProtocolProtocolNameEnumType ProtocolName { get; set; }
        /// <summary>
        /// The expected SSH fingerprint of the server. If the server's fingerprint
        /// does not match this fingerprint, the connection will be terminated.
        /// 
        /// Only ECDSA fingerprints hashed with SHA256 are supported. To obtain the
        /// host's ssh fingerprint, you should connect via some method other than
        /// SSH to obtain this information. You can use one of these commands to
        /// view the key's fingerprint:
        /// 1. ssh-keygen -l -E sha256 -f ssh_host_ecdsa_key.pub
        /// 2. awk '{print $2}' ssh_host_ecdsa_key.pub | base64 -d | sha256sum -b |
        /// sed 's/ .*$//' | xxd -r -p | base64 | sed 's/.//44g' |
        /// awk '{print "SHA256:"$1}'
        /// </summary>
        [JsonProperty(PropertyName = "ssh_fingerprint", Required = Required.AllowNull)]
        public string SshFingerprint { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "authentication_scheme", Required = Required.AllowNull)]
        public NSXTFileTransferAuthenticationSchemeType AuthenticationScheme { get; set; }
    }
}
