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
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTUploadBundleRemoteServerType : NSXTPolicyConfigResourceType
    {
        /// <summary>
        /// Relative path to download file.
        /// </summary>
        [JsonProperty(PropertyName = "uri", Required = Required.AllowNull)]
        public string Uri { get; set; }
        /// <summary>
        /// Protocol used HTTP or HTTPS.
        /// </summary>
        [JsonProperty(PropertyName = "protocol", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTUploadBundleRemoteServerProtocolEnumType Protocol { get; set; }
        /// <summary>
        /// Port to connect with.
        /// </summary>
        [JsonProperty(PropertyName = "port")]
        public string? Port { get; set; }
        /// <summary>
        /// Server IP or FQDN.
        /// </summary>
        [JsonProperty(PropertyName = "server", Required = Required.AllowNull)]
        public string Server { get; set; }
    }
}
