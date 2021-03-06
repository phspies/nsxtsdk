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
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTAbstractSpaceType : NSXTPolicyConfigResourceType
    {
        /// <summary>
        /// The connectivity strategy is deprecated. Use default layer3 rule,
        /// /infra/domains/default/security-policies/default-layer3-security-policy/rules/default-layer3-rule.
        /// This field indicates the default connectivity policy for the infra
        /// or tenant space
        /// WHITELIST - Adds a default drop rule. Administrator can then use "allow"
        /// rules (aka whitelist) to allow traffic between groups
        /// BLACKLIST - Adds a default allow rule. Admin can then use "drop" rules
        /// (aka blacklist) to block traffic between groups
        /// WHITELIST_ENABLE_LOGGING - Whitelising with logging enabled
        /// BLACKLIST_ENABLE_LOGGING - Blacklisting with logging enabled
        /// NONE - No default rules are added.
        /// </summary>
        [JsonProperty(PropertyName = "connectivity_strategy")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTAbstractSpaceConnectivityStrategyEnumType? ConnectivityStrategy { get; set; }
    }
}
