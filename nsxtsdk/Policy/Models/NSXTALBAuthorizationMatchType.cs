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
    /// Advanced load balancer AuthorizationMatch object
    /// </summary>
    [NSXTProperty(Description: @"Advanced load balancer AuthorizationMatch object")]
    public class NSXTALBAuthorizationMatchType 
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "host_hdr")]
        public NSXTALBHostHdrMatchType HostHdr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "path")]
        public NSXTALBPathMatchType Path { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "method")]
        public NSXTALBMethodMatchType Method { get; set; }
        /// <summary>
        /// Attributes whose values need to be matched.
        /// Allowed in Basic edition, Essentials edition, Enterprise
        /// edition.
        /// </summary>
        [JsonProperty(PropertyName = "attr_matches")]
        public IList<NSXTALBAuthAttributeMatchType> AttrMatches { get; set; }
    }
}
