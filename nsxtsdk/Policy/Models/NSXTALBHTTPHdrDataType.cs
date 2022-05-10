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
    /// Advanced load balancer HTTPHdrData object
    /// </summary>
    [NSXTProperty(Description: @"Advanced load balancer HTTPHdrData object")]
    public class NSXTALBHTTPHdrDataType 
    {
        /// <summary>
        /// HTTP header name.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string? Name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public NSXTALBHTTPHdrValueType Value { get; set; }
    }
}
