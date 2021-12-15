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
    /// Advanced load balancer AuthorizationMatch object
    /// </summary>
    [NSXTProperty(Description: @"Advanced load balancer AuthorizationMatch object")]
    public class NSXTALBAuthorizationMatchType 
    {
        /// <summary>
        /// Host header value to be matched.
        /// </summary>
        [JsonProperty(PropertyName = "host_hdr")]
        [NSXTProperty(IsRequired: false, Description: @"Host header value to be matched.")]
        public NSXTALBHostHdrMatchType HostHdr { get; set; }
        /// <summary>
        /// Paths/URLs to be matched.
        /// </summary>
        [JsonProperty(PropertyName = "path")]
        [NSXTProperty(IsRequired: false, Description: @"Paths/URLs to be matched.")]
        public NSXTALBPathMatchType Path { get; set; }
        /// <summary>
        /// HTTP methods to be matched.
        /// </summary>
        [JsonProperty(PropertyName = "method")]
        [NSXTProperty(IsRequired: false, Description: @"HTTP methods to be matched.")]
        public NSXTALBMethodMatchType Method { get; set; }
        /// <summary>
        /// Attributes whose values need to be matched .
        /// </summary>
        [JsonProperty(PropertyName = "attr_matches")]
        [NSXTProperty(IsRequired: false, Description: @"Attributes whose values need to be matched .")]
        public IList<NSXTALBAuthAttributeMatchType> AttrMatches { get; set; }
    }
}