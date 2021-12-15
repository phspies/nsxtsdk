// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using nsxtsdk.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using NJsonSchema.Converters;
using System.ComponentModel;

namespace nsxtsdk.ManagerModels
{
    /// <summary>
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTLbHttpMonitorType : NSXTLbActiveMonitorType
    {
        /// <summary>
        /// The HTTP response status code should be a valid HTTP status code.
        /// </summary>
        [JsonProperty(PropertyName = "response_status_codes")]
        [NSXTProperty(IsRequired: false, Description: @"The HTTP response status code should be a valid HTTP status code.")]
        public int? ResponseStatusCodes { get; set; }
        /// <summary>
        /// the health check method for HTTP monitor type
        /// </summary>
        [JsonProperty(PropertyName = "request_method")]
        [NSXTProperty(IsRequired: false, Description: @"the health check method for HTTP monitor type")]
        [NSXTDefaultProperty(Default: "GET")]
        public NSXTLbHttpMonitorRequestMethodEnumType? RequestMethod { get; set; }
        /// <summary>
        /// String to send as part of HTTP health check request body. Valid only
        /// for certain HTTP methods like POST.
        /// </summary>
        [JsonProperty(PropertyName = "request_body")]
        [NSXTProperty(IsRequired: false, Description: @"String to send as part of HTTP health check request body. Valid onlyfor certain HTTP methods like POST.")]
        public string? RequestBody { get; set; }
        /// <summary>
        /// If HTTP response body match string (regular expressions not supported)
        /// is specified (using LbHttpMonitor.response_body) then the
        /// healthcheck HTTP response body is matched against the specified string
        /// and server is considered healthy only if there is a match.
        /// If the response body string is not specified, HTTP healthcheck is
        /// considered successful if the HTTP response status code is 2xx, but it
        /// can be configured to accept other status codes as successful.
        /// </summary>
        [JsonProperty(PropertyName = "response_body")]
        [NSXTProperty(IsRequired: false, Description: @"If HTTP response body match string (regular expressions not supported)is specified (using LbHttpMonitor.response_body) then thehealthcheck HTTP response body is matched against the specified stringand server is considered healthy only if there is a match.If the response body string is not specified, HTTP healthcheck isconsidered successful if the HTTP response status code is 2xx, but itcan be configured to accept other status codes as successful.")]
        public string? ResponseBody { get; set; }
        /// <summary>
        /// URL used for HTTP monitor
        /// </summary>
        [JsonProperty(PropertyName = "request_url")]
        [NSXTProperty(IsRequired: false, Description: @"URL used for HTTP monitor")]
        public string? RequestUrl { get; set; }
        /// <summary>
        /// HTTP request version
        /// </summary>
        [JsonProperty(PropertyName = "request_version")]
        [NSXTProperty(IsRequired: false, Description: @"HTTP request version")]
        [NSXTDefaultProperty(Default: "HTTP_VERSION_1_1")]
        public NSXTLbHttpMonitorRequestVersionEnumType? RequestVersion { get; set; }
        /// <summary>
        /// Array of HTTP request headers
        /// </summary>
        [JsonProperty(PropertyName = "request_headers")]
        [NSXTProperty(IsRequired: false, Description: @"Array of HTTP request headers")]
        public IList<NSXTLbHttpRequestHeaderType> RequestHeaders { get; set; }
    }
}