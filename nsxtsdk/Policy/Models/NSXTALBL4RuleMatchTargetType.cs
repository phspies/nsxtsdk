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
    /// Advanced load balancer L4RuleMatchTarget object
    /// </summary>
    [NSXTProperty(Description: @"Advanced load balancer L4RuleMatchTarget object")]
    public class NSXTALBL4RuleMatchTargetType 
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "client_ip")]
        public NSXTALBIpAddrMatchType ClientIp { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "protocol")]
        public NSXTALBL4RuleProtocolMatchType Protocol { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "port")]
        public NSXTALBL4RulePortMatchType Port { get; set; }
    }
}
