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
        [NSXTProperty(IsRequired: false, Description: @"Allow retry of non-idempotent HTTP requests.Default value when not specified in API or module isinterpreted by ALB Controller as false.")]
        public bool? RetryNonidempotent { get; set; }
        /// <summary>
        /// Number of times to retry an HTTP request when server
        /// responds with configured status codes.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as 4.
        /// </summary>
        [JsonProperty(PropertyName = "num_retries")]
        [NSXTProperty(IsRequired: false, Description: @"Number of times to retry an HTTP request when serverresponds with configured status codes.Default value when not specified in API or module isinterpreted by ALB Controller as 4.")]
        [NSXTDefaultProperty(Default: "")]
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
        [NSXTProperty(IsRequired: false, Description: @"Timeout per retry attempt, for a given request.Value of 0 indicates default timeout.Allowed values are 0-3600000.Unit is MILLISECONDS.Default value when not specified in API or module isinterpreted by ALB Controller as 0.")]
        //[System.ComponentModel.DataAnnotations.MinLength(0)]
        //[System.ComponentModel.DataAnnotations.MaxLength(3600000)]
        [NSXTDefaultProperty(Default: "")]
        public long? RetryTimeout { get; set; }
        /// <summary>
        /// Enable HTTP request reselect when server responds with
        /// specific response codes.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as false.
        /// </summary>
        [JsonProperty(PropertyName = "enabled", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"Enable HTTP request reselect when server responds withspecific response codes.Default value when not specified in API or module isinterpreted by ALB Controller as false.")]
        [System.ComponentModel.DataAnnotations.Required]
        public bool Enabled { get; set; }
        /// <summary>
        /// Server response codes which will trigger an HTTP request
        /// retry.
        /// </summary>
        [JsonProperty(PropertyName = "svr_resp_code")]
        [NSXTProperty(IsRequired: false, Description: @"Server response codes which will trigger an HTTP requestretry.")]
        public NSXTALBHTTPReselectRespCodeType SvrRespCode { get; set; }
    }
}
