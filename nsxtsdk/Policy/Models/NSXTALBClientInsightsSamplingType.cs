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
    /// Advanced load balancer ClientInsightsSampling object
    /// </summary>
    [NSXTProperty(Description: @"Advanced load balancer ClientInsightsSampling object")]
    public class NSXTALBClientInsightsSamplingType 
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "skip_uris")]
        public NSXTALBStringMatchType SkipUris { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "client_ip")]
        public NSXTALBIpAddrMatchType ClientIp { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "sample_uris")]
        public NSXTALBStringMatchType SampleUris { get; set; }
    }
}
