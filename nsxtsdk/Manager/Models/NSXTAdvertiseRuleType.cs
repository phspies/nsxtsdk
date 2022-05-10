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
    public class NSXTAdvertiseRuleType 
    {
        /// <summary>
        /// ALLOW action enables the advertisment and DENY action disables the advertisement of a filtered routes to the connected
        /// TIER0 router.
        /// </summary>
        [JsonProperty(PropertyName = "action")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTAdvertiseRuleActionEnumType? Action { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "rule_filter")]
        public NSXTAdvertisementRuleFilterType RuleFilter { get; set; }
        /// <summary>
        /// Display name
        /// </summary>
        [JsonProperty(PropertyName = "display_name")]
        public string? DisplayName { get; set; }
        /// <summary>
        /// network(CIDR) to be routed
        /// </summary>
        [JsonProperty(PropertyName = "networks", Required = Required.AllowNull)]
        public IList<string> Networks { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string? Description { get; set; }
    }
}
