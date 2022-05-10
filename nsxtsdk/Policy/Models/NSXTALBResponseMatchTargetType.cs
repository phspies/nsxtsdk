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
    /// Advanced load balancer ResponseMatchTarget object
    /// </summary>
    [NSXTProperty(Description: @"Advanced load balancer ResponseMatchTarget object")]
    public class NSXTALBResponseMatchTargetType 
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public NSXTALBHTTPStatusMatchType Status { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "client_ip")]
        public NSXTALBIpAddrMatchType ClientIp { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "protocol")]
        public NSXTALBProtocolMatchType Protocol { get; set; }
        /// <summary>
        /// Configure HTTP headers.
        /// </summary>
        [JsonProperty(PropertyName = "hdrs")]
        public IList<NSXTALBHdrMatchType> Hdrs { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "loc_hdr")]
        public NSXTALBLocationHdrMatchType LocHdr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "host_hdr")]
        public NSXTALBHostHdrMatchType HostHdr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "vs_port")]
        public NSXTALBPortMatchType VsPort { get; set; }
        /// <summary>
        /// Configure the HTTP headers in response.
        /// </summary>
        [JsonProperty(PropertyName = "rsp_hdrs")]
        public IList<NSXTALBHdrMatchType> RspHdrs { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "cookie")]
        public NSXTALBCookieMatchType Cookie { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "version")]
        public NSXTALBHTTPVersionMatchType Version { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "query")]
        public NSXTALBQueryMatchType Query { get; set; }
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
    }
}
