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
    /// Advanced Load Balancer controller cluster runtime error.
    /// </summary>
    [NSXTProperty(Description: @"Advanced Load Balancer controller cluster runtime error.")]
    public class NSXTAlbControllerClusterRuntimeErrorType 
    {
        /// <summary>
        /// Advanced Load Balancer cluster runtime error msg.
        /// </summary>
        [JsonProperty(PropertyName = "error_message")]
        public string? ErrorMessage { get; set; }
        /// <summary>
        /// Advanced Load Balancer cluster runtime error code.
        /// </summary>
        [JsonProperty(PropertyName = "error_code")]
        public int? ErrorCode { get; set; }
    }
}
