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
    public class NSXTAddManagementNodeSpecType 
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "mpa_msg_client_info")]
        public NSXTMsgClientInfoType MpaMsgClientInfo { get; set; }
        /// <summary>
        /// must be set to AddManagementNodeSpec
        /// </summary>
        [JsonProperty(PropertyName = "type", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTAddManagementNodeSpecTypeEnumType Type { get; set; }
        /// <summary>
        /// The password to be used to authenticate with the remote node.
        /// </summary>
        [JsonProperty(PropertyName = "password")]
        public string? Password { get; set; }
        /// <summary>
        /// The username to be used to authenticate with the remote node.
        /// </summary>
        [JsonProperty(PropertyName = "user_name", Required = Required.AllowNull)]
        public string UserName { get; set; }
        /// <summary>
        /// The host address of the remote node to which to send this join request.
        /// </summary>
        [JsonProperty(PropertyName = "remote_address", Required = Required.AllowNull)]
        public string RemoteAddress { get; set; }
        /// <summary>
        /// The certificate thumbprint of the remote node.
        /// </summary>
        [JsonProperty(PropertyName = "cert_thumbprint")]
        public string? CertThumbprint { get; set; }
    }
}
