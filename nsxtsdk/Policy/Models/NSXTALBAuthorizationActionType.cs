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
    /// Advanced load balancer AuthorizationAction object
    /// </summary>
    [NSXTProperty(Description: @"Advanced load balancer AuthorizationAction object")]
    public class NSXTALBAuthorizationActionType 
    {
        /// <summary>
        /// HTTP status code to use for local response when an policy
        /// rule is matched.
        /// Enum options - HTTP_RESPONSE_STATUS_CODE_401,
        /// HTTP_RESPONSE_STATUS_CODE_403.
        /// </summary>
        [JsonProperty(PropertyName = "status_code")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTAlbauthorizationActionStatusCodeEnumType? StatusCode { get; set; }
        /// <summary>
        /// Defines the action taken when an authorization policy rule
        /// is matched.
        /// By default, access is allowed to the requested resource.
        /// Enum options - ALLOW_ACCESS, CLOSE_CONNECTION,
        /// HTTP_LOCAL_RESPONSE.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as ALLOW_ACCESS.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTAlbauthorizationActionTypeEnumType? Type { get; set; }
    }
}
