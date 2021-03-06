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
    /// Advanced load balancer HSMThalesRFS object
    /// </summary>
    [NSXTProperty(Description: @"Advanced load balancer HSMThalesRFS object")]
    public class NSXTALBHSMThalesRFSType 
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "ip", Required = Required.AllowNull)]
        public NSXTALBIpAddrType Ip { get; set; }
        /// <summary>
        /// Port at which the RFS server accepts the sync request from
        /// clients for Thales encrypted private key.
        /// Allowed values are 1-65535.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as 9004.
        /// </summary>
        [JsonProperty(PropertyName = "port")]
        public long? Port { get; set; }
    }
}
