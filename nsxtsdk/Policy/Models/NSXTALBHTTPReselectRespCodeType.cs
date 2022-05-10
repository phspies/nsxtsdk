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
    /// Advanced load balancer HTTPReselectRespCode object
    /// </summary>
    [NSXTProperty(Description: @"Advanced load balancer HTTPReselectRespCode object")]
    public class NSXTALBHTTPReselectRespCodeType 
    {
        /// <summary>
        /// HTTP response code ranges to match.
        /// </summary>
        [JsonProperty(PropertyName = "ranges")]
        public IList<NSXTALBHTTPStatusRangeType> Ranges { get; set; }
        /// <summary>
        /// HTTP response code to be matched.
        /// Allowed values are 400-599.
        /// </summary>
        [JsonProperty(PropertyName = "codes")]
        public long? Codes { get; set; }
        /// <summary>
        /// Block of HTTP response codes to match for server reselect.
        /// Enum options - HTTP_RSP_4XX, HTTP_RSP_5XX.
        /// </summary>
        [JsonProperty(PropertyName = "resp_code_block")]
        public IList<string> RespCodeBlock { get; set; }
    }
}
