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
    /// Advanced load balancer HTTPRewriteURLAction object
    /// </summary>
    [NSXTProperty(Description: @"Advanced load balancer HTTPRewriteURLAction object")]
    public class NSXTALBHTTPRewriteURLActionType 
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "host_hdr")]
        public NSXTALBURIParamType HostHdr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "query")]
        public NSXTALBURIParamQueryType Query { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "path")]
        public NSXTALBURIParamType Path { get; set; }
    }
}
