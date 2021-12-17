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
    /// Advanced load balancer MatchTarget object
    /// </summary>
    [NSXTProperty(Description: @"Advanced load balancer MatchTarget object")]
    public class NSXTALBMatchTargetType 
    {
        public NSXTALBMatchTargetType()
        {
        }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "host_hdr")]
        [NSXTProperty(IsRequired: false, Description: @"")]
        public NSXTALBHostHdrMatchType HostHdr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "client_ip")]
        [NSXTProperty(IsRequired: false, Description: @"")]
        public NSXTALBIpAddrMatchType ClientIp { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "version")]
        [NSXTProperty(IsRequired: false, Description: @"")]
        public NSXTALBHTTPVersionMatchType Version { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "protocol")]
        [NSXTProperty(IsRequired: false, Description: @"")]
        public NSXTALBProtocolMatchType Protocol { get; set; }
        /// <summary>
        /// Configure HTTP header(s).
        /// </summary>
        [JsonProperty(PropertyName = "hdrs")]
        [NSXTProperty(IsRequired: false, Description: @"Configure HTTP header(s).")]
        public IList<NSXTALBHdrMatchType> Hdrs { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "query")]
        [NSXTProperty(IsRequired: false, Description: @"")]
        public NSXTALBQueryMatchType Query { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "cookie")]
        [NSXTProperty(IsRequired: false, Description: @"")]
        public NSXTALBCookieMatchType Cookie { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "path")]
        [NSXTProperty(IsRequired: false, Description: @"")]
        public NSXTALBPathMatchType Path { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "vs_port")]
        [NSXTProperty(IsRequired: false, Description: @"")]
        public NSXTALBPortMatchType VsPort { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "method")]
        [NSXTProperty(IsRequired: false, Description: @"")]
        public NSXTALBMethodMatchType Method { get; set; }
    }
}
