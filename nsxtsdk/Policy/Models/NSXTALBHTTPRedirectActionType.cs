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
    /// Advanced load balancer HTTPRedirectAction object
    /// </summary>
    [NSXTProperty(Description: @"Advanced load balancer HTTPRedirectAction object")]
    public class NSXTALBHTTPRedirectActionType 
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "host")]
        public NSXTALBURIParamType Host { get; set; }
        /// <summary>
        /// Protocol type.
        /// Enum options - HTTP, HTTPS.
        /// </summary>
        [JsonProperty(PropertyName = "protocol", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTAlbhttpredirectActionProtocolEnumType Protocol { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "path")]
        public NSXTALBURIParamType Path { get; set; }
        /// <summary>
        /// Keep or drop the query of the incoming request URI in the
        /// redirected URI.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as true.
        /// </summary>
        [JsonProperty(PropertyName = "keep_query")]
        public bool? KeepQuery { get; set; }
        /// <summary>
        /// HTTP redirect status code.
        /// Enum options - HTTP_REDIRECT_STATUS_CODE_301,
        /// HTTP_REDIRECT_STATUS_CODE_302,
        /// HTTP_REDIRECT_STATUS_CODE_307.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as
        /// HTTP_REDIRECT_STATUS_CODE_302.
        /// </summary>
        [JsonProperty(PropertyName = "status_code")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTAlbhttpredirectActionStatusCodeEnumType? StatusCode { get; set; }
        /// <summary>
        /// Port to which redirect the request.
        /// Allowed values are 1-65535.
        /// </summary>
        [JsonProperty(PropertyName = "port")]
        public long? Port { get; set; }
    }
}
