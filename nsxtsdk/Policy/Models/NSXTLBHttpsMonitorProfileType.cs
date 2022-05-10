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
    public class NSXTLBHttpsMonitorProfileType : NSXTLBActiveMonitorType
    {
        /// <summary>
        /// The HTTP response status code should be a valid HTTP status code.
        /// </summary>
        [JsonProperty(PropertyName = "response_status_codes")]
        public int? ResponseStatusCodes { get; set; }
        /// <summary>
        /// The health check method for HTTP monitor type.
        /// </summary>
        [JsonProperty(PropertyName = "request_method")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTLbhttpsMonitorProfileRequestMethodEnumType? RequestMethod { get; set; }
        /// <summary>
        /// String to send as part of HTTP health check request body. Valid only
        /// for certain HTTP methods like POST.
        /// </summary>
        [JsonProperty(PropertyName = "request_body")]
        public string? RequestBody { get; set; }
        /// <summary>
        /// If HTTP response body match string (regular expressions not supported)
        /// is specified (using LBHttpMonitor.response_body) then the
        /// healthcheck HTTP response body is matched against the specified string
        /// and server is considered healthy only if there is a match.
        /// If the response body string is not specified, HTTP healthcheck is
        /// considered successful if the HTTP response status code is 2xx, but it
        /// can be configured to accept other status codes as successful.
        /// </summary>
        [JsonProperty(PropertyName = "response_body")]
        public string? ResponseBody { get; set; }
        /// <summary>
        /// For HTTPS active healthchecks, the HTTPS request url sent can be
        /// customized and can include query parameters.
        /// </summary>
        [JsonProperty(PropertyName = "request_url")]
        public string? RequestUrl { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "server_ssl_profile_binding")]
        public NSXTLBServerSslProfileBindingType ServerSslProfileBinding { get; set; }
        /// <summary>
        /// HTTP request version.
        /// </summary>
        [JsonProperty(PropertyName = "request_version")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTLbhttpsMonitorProfileRequestVersionEnumType? RequestVersion { get; set; }
        /// <summary>
        /// Array of HTTP request headers.
        /// </summary>
        [JsonProperty(PropertyName = "request_headers")]
        public IList<NSXTLbHttpRequestHeaderType> RequestHeaders { get; set; }
    }
}
