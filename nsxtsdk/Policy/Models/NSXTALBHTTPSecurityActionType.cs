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
    /// Advanced load balancer HTTPSecurityAction object
    /// </summary>
    [NSXTProperty(Description: @"Advanced load balancer HTTPSecurityAction object")]
    public class NSXTALBHTTPSecurityActionType 
    {
        /// <summary>
        /// Type of the security action to perform.
        /// Enum options - HTTP_SECURITY_ACTION_CLOSE_CONN,
        /// HTTP_SECURITY_ACTION_SEND_RESPONSE,
        /// HTTP_SECURITY_ACTION_ALLOW,
        /// HTTP_SECURITY_ACTION_REDIRECT_TO_HTTPS,
        /// HTTP_SECURITY_ACTION_RATE_LIMIT,
        /// HTTP_SECURITY_ACTION_REQUEST_CHECK_ICAP.
        /// Allowed in Basic(Allowed values-
        /// HTTP_SECURITY_ACTION_CLOSE_CONN,HTTP_SECURITY_ACTION_SEND_RESPONSE,HTTP_SECURITY_ACTION_REDIRECT_TO_HTTPS)
        /// edition, Essentials(Allowed values-
        /// HTTP_SECURITY_ACTION_CLOSE_CONN,HTTP_SECURITY_ACTION_SEND_RESPONSE,HTTP_SECURITY_ACTION_REDIRECT_TO_HTTPS)
        /// edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "action", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTAlbhttpsecurityActionActionEnumType Action { get; set; }
        /// <summary>
        /// HTTP status code to use for local response.
        /// Enum options - HTTP_LOCAL_RESPONSE_STATUS_CODE_200,
        /// HTTP_LOCAL_RESPONSE_STATUS_CODE_204,
        /// HTTP_LOCAL_RESPONSE_STATUS_CODE_403,
        /// HTTP_LOCAL_RESPONSE_STATUS_CODE_404,
        /// HTTP_LOCAL_RESPONSE_STATUS_CODE_429,
        /// HTTP_LOCAL_RESPONSE_STATUS_CODE_501.
        /// </summary>
        [JsonProperty(PropertyName = "status_code")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTAlbhttpsecurityActionStatusCodeEnumType? StatusCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "rate_profile")]
        public NSXTALBHTTPSecurityActionRateProfileType RateProfile { get; set; }
        /// <summary>
        /// Secure SSL/TLS port to redirect the HTTP request to.
        /// Allowed values are 1-65535.
        /// </summary>
        [JsonProperty(PropertyName = "https_port")]
        public long? HttpsPort { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "file")]
        public NSXTALBHTTPLocalFileType File { get; set; }
    }
}
