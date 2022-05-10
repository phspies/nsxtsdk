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
    /// Advanced load balancer WafPSMLocationMatch object
    /// </summary>
    [NSXTProperty(Description: @"Advanced load balancer WafPSMLocationMatch object")]
    public class NSXTALBWafPSMLocationMatchType 
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "path")]
        public NSXTALBPathMatchType Path { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "host")]
        public NSXTALBHostHdrMatchType Host { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "methods")]
        public NSXTALBMethodMatchType Methods { get; set; }
    }
}
