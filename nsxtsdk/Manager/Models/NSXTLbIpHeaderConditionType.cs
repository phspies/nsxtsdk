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
    public class NSXTLbIpHeaderConditionType : NSXTLbRuleConditionType
    {
        /// <summary>
        /// Source IP address of HTTP message should match IP addresses which are
        /// configured in Group in order to perform actions.
        /// </summary>
        [JsonProperty(PropertyName = "group_id")]
        public string? GroupId { get; set; }
        /// <summary>
        /// Source IP address of HTTP message. IP Address can be expressed as a
        /// single IP address like 10.1.1.1, or a range of IP addresses like
        /// 10.1.1.101-10.1.1.160. Both IPv4 and IPv6 addresses are supported.
        /// </summary>
        [JsonProperty(PropertyName = "source_address")]
        public string? SourceAddress { get; set; }
    }
}
