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
    /// Advanced load balancer RateLimiterAction object
    /// </summary>
    [NSXTProperty(Description: @"Advanced load balancer RateLimiterAction object")]
    public class NSXTALBRateLimiterActionType 
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "redirect")]
        public NSXTALBHTTPRedirectActionType Redirect { get; set; }
        /// <summary>
        /// HTTP status code for Local Response rate limit action.
        /// Enum options - HTTP_LOCAL_RESPONSE_STATUS_CODE_200,
        /// HTTP_LOCAL_RESPONSE_STATUS_CODE_204,
        /// HTTP_LOCAL_RESPONSE_STATUS_CODE_403,
        /// HTTP_LOCAL_RESPONSE_STATUS_CODE_404,
        /// HTTP_LOCAL_RESPONSE_STATUS_CODE_429,
        /// HTTP_LOCAL_RESPONSE_STATUS_CODE_501.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as
        /// HTTP_LOCAL_RESPONSE_STATUS_CODE_429.
        /// </summary>
        [JsonProperty(PropertyName = "status_code")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTAlbrateLimiterActionStatusCodeEnumType? StatusCode { get; set; }
        /// <summary>
        /// Type of action to be enforced upon hitting the rate limit.
        /// Enum options - RL_ACTION_NONE, RL_ACTION_DROP_CONN,
        /// RL_ACTION_RESET_CONN, RL_ACTION_CLOSE_CONN,
        /// RL_ACTION_LOCAL_RSP, RL_ACTION_REDIRECT.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as RL_ACTION_NONE.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTAlbrateLimiterActionTypeEnumType? Type { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "file")]
        public NSXTALBHTTPLocalFileType File { get; set; }
    }
}
