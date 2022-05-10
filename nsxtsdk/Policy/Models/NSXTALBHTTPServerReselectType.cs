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
    /// Advanced load balancer HTTPServerReselect object
    /// </summary>
    [NSXTProperty(Description: @"Advanced load balancer HTTPServerReselect object")]
    public class NSXTALBHTTPServerReselectType 
    {
        /// <summary>
        /// Allow retry of non-idempotent HTTP requests.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as false.
        /// </summary>
        [JsonProperty(PropertyName = "retry_nonidempotent")]
        public bool? RetryNonidempotent { get; set; }
        /// <summary>
        /// Number of times to retry an HTTP request when server
        /// responds with configured status codes.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as 4.
        /// </summary>
        [JsonProperty(PropertyName = "num_retries")]
        public long? NumRetries { get; set; }
        /// <summary>
        /// Timeout per retry attempt, for a given request.
        /// Value of 0 indicates default timeout.
        /// Allowed values are 0-3600000.
        /// Unit is MILLISECONDS.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as 0.
        /// </summary>
        [JsonProperty(PropertyName = "retry_timeout")]
        public long? RetryTimeout { get; set; }
        /// <summary>
        /// Enable HTTP request reselect when server responds with
        /// specific response codes.
        /// Allowed in Basic(Allowed values- false) edition,
        /// Essentials(Allowed values- false) edition, Enterprise
        /// edition.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as false.
        /// </summary>
        [JsonProperty(PropertyName = "enabled", Required = Required.AllowNull)]
        public bool Enabled { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "svr_resp_code")]
        public NSXTALBHTTPReselectRespCodeType SvrRespCode { get; set; }
    }
}
