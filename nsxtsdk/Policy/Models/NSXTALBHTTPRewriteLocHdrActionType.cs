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
    /// Advanced load balancer HTTPRewriteLocHdrAction object
    /// </summary>
    [NSXTProperty(Description: @"Advanced load balancer HTTPRewriteLocHdrAction object")]
    public class NSXTALBHTTPRewriteLocHdrActionType 
    {
        /// <summary>
        /// Keep or drop the query from the server side redirect URI.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as true.
        /// </summary>
        [JsonProperty(PropertyName = "keep_query")]
        public bool? KeepQuery { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "path")]
        public NSXTALBURIParamType Path { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "host")]
        public NSXTALBURIParamType Host { get; set; }
        /// <summary>
        /// HTTP protocol type.
        /// Enum options - HTTP, HTTPS.
        /// </summary>
        [JsonProperty(PropertyName = "protocol", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTAlbhttprewriteLocHdrActionProtocolEnumType Protocol { get; set; }
        /// <summary>
        /// Port to use in the redirected URI.
        /// Allowed values are 1-65535.
        /// </summary>
        [JsonProperty(PropertyName = "port")]
        public long? Port { get; set; }
    }
}
