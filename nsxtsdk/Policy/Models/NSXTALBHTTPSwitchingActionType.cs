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
    /// Advanced load balancer HTTPSwitchingAction object
    /// </summary>
    [NSXTProperty(Description: @"Advanced load balancer HTTPSwitchingAction object")]
    public class NSXTALBHTTPSwitchingActionType 
    {
        /// <summary>
        /// path of the pool of servers to serve the request.
        /// It is a reference to an object of type Pool.
        /// </summary>
        [JsonProperty(PropertyName = "pool_path")]
        public string? PoolPath { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "file")]
        public NSXTALBHTTPLocalFileType File { get; set; }
        /// <summary>
        /// path of the pool group to serve the request.
        /// It is a reference to an object of type PoolGroup.
        /// </summary>
        [JsonProperty(PropertyName = "pool_group_path")]
        public string? PoolGroupPath { get; set; }
        /// <summary>
        /// Content switching action type.
        /// Enum options - HTTP_SWITCHING_SELECT_POOL,
        /// HTTP_SWITCHING_SELECT_LOCAL,
        /// HTTP_SWITCHING_SELECT_POOLGROUP.
        /// Allowed in Essentials(Allowed values-
        /// HTTP_SWITCHING_SELECT_POOL,HTTP_SWITCHING_SELECT_LOCAL)
        /// edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "action", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTAlbhttpswitchingActionActionEnumType Action { get; set; }
        /// <summary>
        /// HTTP status code to use when serving local response.
        /// Enum options - HTTP_LOCAL_RESPONSE_STATUS_CODE_200,
        /// HTTP_LOCAL_RESPONSE_STATUS_CODE_204,
        /// HTTP_LOCAL_RESPONSE_STATUS_CODE_403,
        /// HTTP_LOCAL_RESPONSE_STATUS_CODE_404,
        /// HTTP_LOCAL_RESPONSE_STATUS_CODE_429,
        /// HTTP_LOCAL_RESPONSE_STATUS_CODE_501.
        /// </summary>
        [JsonProperty(PropertyName = "status_code")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTAlbhttpswitchingActionStatusCodeEnumType? StatusCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "server")]
        public NSXTALBPoolServerType Server { get; set; }
    }
}
