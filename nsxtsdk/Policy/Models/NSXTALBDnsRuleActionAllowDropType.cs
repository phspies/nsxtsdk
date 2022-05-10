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
    /// Advanced load balancer DnsRuleActionAllowDrop object
    /// </summary>
    [NSXTProperty(Description: @"Advanced load balancer DnsRuleActionAllowDrop object")]
    public class NSXTALBDnsRuleActionAllowDropType 
    {
        /// <summary>
        /// Reset the TCP connection of the DNS query, if allow is set
        /// to false to drop the query.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as true.
        /// </summary>
        [JsonProperty(PropertyName = "reset_conn")]
        public bool? ResetConn { get; set; }
        /// <summary>
        /// Allow the DNS query.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as true.
        /// </summary>
        [JsonProperty(PropertyName = "allow")]
        public bool? Allow { get; set; }
    }
}
