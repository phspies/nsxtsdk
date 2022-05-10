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
    /// Advanced load balancer FailActionHTTPRedirect object
    /// </summary>
    [NSXTProperty(Description: @"Advanced load balancer FailActionHTTPRedirect object")]
    public class NSXTALBFailActionHTTPRedirectType 
    {
        /// <summary>
        /// path of FailActionHTTPRedirect.
        /// </summary>
        [JsonProperty(PropertyName = "path")]
        public string? Path { get; set; }
        /// <summary>
        /// host of FailActionHTTPRedirect.
        /// </summary>
        [JsonProperty(PropertyName = "host", Required = Required.AllowNull)]
        public string Host { get; set; }
        /// <summary>
        /// Enum options - HTTP, HTTPS.
        /// Allowed in Basic(Allowed values- HTTP) edition, Enterprise
        /// edition.
        /// Special default for Basic edition is HTTP, Enterprise is
        /// HTTPS.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as HTTP.
        /// </summary>
        [JsonProperty(PropertyName = "protocol")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTAlbfailActionHttpredirectProtocolEnumType? Protocol { get; set; }
        /// <summary>
        /// Enum options - HTTP_REDIRECT_STATUS_CODE_301,
        /// HTTP_REDIRECT_STATUS_CODE_302,
        /// HTTP_REDIRECT_STATUS_CODE_307.
        /// Allowed in Basic(Allowed values-
        /// HTTP_REDIRECT_STATUS_CODE_302) edition, Enterprise edition.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as
        /// HTTP_REDIRECT_STATUS_CODE_302.
        /// </summary>
        [JsonProperty(PropertyName = "status_code")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTAlbfailActionHttpredirectStatusCodeEnumType? StatusCode { get; set; }
        /// <summary>
        /// query of FailActionHTTPRedirect.
        /// </summary>
        [JsonProperty(PropertyName = "query")]
        public string? Query { get; set; }
    }
}
