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
    /// Advanced load balancer HTTPStatusRange object
    /// </summary>
    [NSXTProperty(Description: @"Advanced load balancer HTTPStatusRange object")]
    public class NSXTALBHTTPStatusRangeType 
    {
        /// <summary>
        /// Starting HTTP response status code.
        /// </summary>
        [JsonProperty(PropertyName = "begin", Required = Required.AllowNull)]
        public long Begin { get; set; }
        /// <summary>
        /// Ending HTTP response status code.
        /// </summary>
        [JsonProperty(PropertyName = "end", Required = Required.AllowNull)]
        public long End { get; set; }
    }
}
