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
    /// Advanced load balancer HealthMonitorHttp object
    /// </summary>
    [NSXTProperty(Description: @"Advanced load balancer HealthMonitorHttp object")]
    public class NSXTALBHealthMonitorHttpType 
    {
        /// <summary>
        /// Type of the authentication method.
        /// Enum options - AUTH_BASIC, AUTH_NTLM.
        /// Allowed in Basic edition, Essentials edition, Enterprise
        /// edition.
        /// </summary>
        [JsonProperty(PropertyName = "auth_type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTAlbhealthMonitorHttpAuthTypeEnumType? AuthType { get; set; }
        /// <summary>
        /// Send an HTTP request to the server.
        /// The default GET / HTTP/1.0 may be extended with additional
        /// headers or information.
        /// For instance, GET /index.htm HTTP/1.1 Host  www.site.com
        /// Connection  Close.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as GET / HTTP/1.0.
        /// </summary>
        [JsonProperty(PropertyName = "http_request")]
        public string? HttpRequest { get; set; }
        /// <summary>
        /// List of HTTP response codes to match as successful.
        /// Default is 2xx.
        /// Enum options - HTTP_ANY, HTTP_1XX, HTTP_2XX, HTTP_3XX,
        /// HTTP_4XX, HTTP_5XX.
        /// Minimum of 1 items required.
        /// </summary>
        [JsonProperty(PropertyName = "http_response_code", Required = Required.AllowNull)]
        public IList<string> HttpResponseCode { get; set; }
        /// <summary>
        /// Expected http/https response page size.
        /// Allowed values are 2048-16384.
        /// </summary>
        [JsonProperty(PropertyName = "response_size")]
        public long? ResponseSize { get; set; }
        /// <summary>
        /// Match for a keyword in the first 2Kb of the server header
        /// and body response.
        /// </summary>
        [JsonProperty(PropertyName = "http_response")]
        public string? HttpResponse { get; set; }
        /// <summary>
        /// Use the exact http_request string as specified by user,
        /// without any automatic insert of headers like Host header.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as false.
        /// </summary>
        [JsonProperty(PropertyName = "exact_http_request")]
        public bool? ExactHttpRequest { get; set; }
        /// <summary>
        /// Match or look for this keyword in the first 2KB of server
        /// header and body response indicating server maintenance.
        /// A successful match results in the server being marked down.
        /// </summary>
        [JsonProperty(PropertyName = "maintenance_response")]
        public string? MaintenanceResponse { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "ssl_attributes")]
        public NSXTALBHealthMonitorSSLAttributesType SslAttributes { get; set; }
        /// <summary>
        /// HTTP request body.
        /// </summary>
        [JsonProperty(PropertyName = "http_request_body")]
        public string? HttpRequestBody { get; set; }
        /// <summary>
        /// Match or look for this HTTP response code indicating server
        /// maintenance.
        /// A successful match results in the server being marked down.
        /// Allowed values are 101-599.
        /// Maximum of 4 items allowed.
        /// </summary>
        [JsonProperty(PropertyName = "maintenance_code")]
        public long? MaintenanceCode { get; set; }
    }
}
