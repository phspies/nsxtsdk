// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using nsxtsdk.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.ComponentModel;
using NJsonSchema.Converters;

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
        public NSXTMsgClientInfoType MpaMsgClientInfo { get; set; }
        /// <summary>
        /// must be set to AddManagementNodeSpec
        /// </summary>
        [JsonProperty(PropertyName = "type", Required = Required.AllowNull)]
        public NSXTAddManagementNodeSpecTypeEnumType Type { get; set; }
        /// <summary>
        /// The password to be used to authenticate with the remote node.
        /// </summary>
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
        public string? CertThumbprint { get; set; }
    }
}
