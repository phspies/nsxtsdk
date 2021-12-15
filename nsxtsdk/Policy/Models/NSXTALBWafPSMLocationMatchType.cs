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
    /// Advanced load balancer WafPSMLocationMatch object
    /// </summary>
    [NSXTProperty(Description: @"Advanced load balancer WafPSMLocationMatch object")]
    public class NSXTALBWafPSMLocationMatchType 
    {
        /// <summary>
        /// Apply the rules only to requests that match the specified
        /// URI.
        /// If this is not set, the path will not be checked.
        /// </summary>
        [JsonProperty(PropertyName = "path")]
        [NSXTProperty(IsRequired: false, Description: @"Apply the rules only to requests that match the specifiedURI.If this is not set, the path will not be checked.")]
        public NSXTALBPathMatchType Path { get; set; }
        /// <summary>
        /// Apply the rules only to requests that match the specified
        /// Host header.
        /// If this is not set, the host header will not be checked.
        /// </summary>
        [JsonProperty(PropertyName = "host")]
        [NSXTProperty(IsRequired: false, Description: @"Apply the rules only to requests that match the specifiedHost header.If this is not set, the host header will not be checked.")]
        public NSXTALBHostHdrMatchType Host { get; set; }
        /// <summary>
        /// Apply the rules only to requests that have the specified
        /// methods.
        /// If this is not set, the method will not be checked.
        /// </summary>
        [JsonProperty(PropertyName = "methods")]
        [NSXTProperty(IsRequired: false, Description: @"Apply the rules only to requests that have the specifiedmethods.If this is not set, the method will not be checked.")]
        public NSXTALBMethodMatchType Methods { get; set; }
    }
}