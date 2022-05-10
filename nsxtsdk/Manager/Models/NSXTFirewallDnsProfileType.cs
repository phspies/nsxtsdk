using nsxtsdk.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.ComponentModel;
using NJsonSchema.Converters;
using Newtonsoft.Json.Converters;

namespace nsxtsdk.ManagerModels
{
    /// <summary>
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTFirewallDnsProfileType : NSXTBaseFirewallProfileType
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "dns_ttl_config")]
        public NSXTDnsTtlConfigType DnsTtlConfig { get; set; }
    }
}
