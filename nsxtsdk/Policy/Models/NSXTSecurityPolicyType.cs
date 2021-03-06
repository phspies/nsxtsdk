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
    public class NSXTSecurityPolicyType : NSXTPolicyType
    {
        /// <summary>
        /// This field indicates the default connectivity policy for the security
        /// policy. Based on the connectivitiy preference, a default rule for this
        /// security policy will be created. An appropriate action will be set on
        /// the rule based on the value of the connectivity preference. If NONE is
        /// selected or no connectivity preference is specified, then no default
        /// rule for the security policy gets created. The default rule that gets
        /// created will be a any-any rule and applied to entities specified in the
        /// scope of the security policy. Specifying the connectivity_preference
        /// without specifying the scope is not allowed. The scope has to be a
        /// Group and one cannot specify IPAddress directly in the group that is
        /// used as scope. This default rule is only applicable for the Layer3
        /// security policies.
        /// ALLOWLIST - Adds a default drop rule. Administrator can then use "allow"
        /// rules to allow traffic between groups
        /// DENYLIST - Adds a default allow rule. Admin can then use "drop" rules
        /// to block traffic between groups
        /// ALLOWLIST_ENABLE_LOGGING - Allowlisting with logging enabled
        /// DENYLIST_ENABLE_LOGGING - Denylisting with logging enabled
        /// NONE - No default rule is created.
        /// </summary>
        [JsonProperty(PropertyName = "connectivity_preference")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTSecurityPolicyConnectivityPreferenceEnumType? ConnectivityPreference { get; set; }
        /// <summary>
        /// This field indicates the application connectivity policy for the security
        /// policy.
        /// </summary>
        [JsonProperty(PropertyName = "application_connectivity_strategy")]
        public IList<NSXTApplicationConnectivityStrategyType> ApplicationConnectivityStrategy { get; set; }
        /// <summary>
        /// Based on the value of the connectivity strategy, a default rule is
        /// created for the security policy. The rule id is internally assigned
        /// by the system for this default rule.
        /// </summary>
        [JsonProperty(PropertyName = "default_rule_id")]
        public long? DefaultRuleId { get; set; }
        /// <summary>
        /// Rules that are a part of this SecurityPolicy
        /// </summary>
        [JsonProperty(PropertyName = "rules")]
        public IList<NSXTRuleType> Rules { get; set; }
        /// <summary>
        /// This field indicates the default connectivity policy for the security
        /// policy. Based on the connectivity strategy, a default rule for this
        /// security policy will be created. An appropriate action will be set on
        /// the rule based on the value of the connectivity strategy. If NONE is
        /// selected or no connectivity strategy is specified, then no default
        /// rule for the security policy gets created. The default rule that gets
        /// created will be a any-any rule and applied to entities specified in the
        /// scope of the security policy. Specifying the connectivity_strategy
        /// without specifying the scope is not allowed. The scope has to be a
        /// Group and one cannot specify IPAddress directly in the group that is
        /// used as scope. This default rule is only applicable for the Layer3
        /// security policies.
        /// This property is deprecated. Use the type connectivity_preference instead.
        /// WHITELIST - Adds a default drop rule. Administrator can then use "allow"
        /// rules (aka whitelist) to allow traffic between groups
        /// BLACKLIST - Adds a default allow rule. Admin can then use "drop" rules
        /// (aka blacklist) to block traffic between groups
        /// WHITELIST_ENABLE_LOGGING - Whitelising with logging enabled
        /// BLACKLIST_ENABLE_LOGGING - Blacklisting with logging enabled
        /// NONE - No default rule is created.
        /// </summary>
        [JsonProperty(PropertyName = "connectivity_strategy")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTSecurityPolicyConnectivityStrategyEnumType? ConnectivityStrategy { get; set; }
        /// <summary>
        /// This property is deprecated.
        /// Flag to enable logging for all the rules in the security policy.
        /// If the value is true then logging will be enabled for all the rules
        /// in the security policy. If the value is false, then the rule level
        /// logging value will be honored.
        /// </summary>
        [JsonProperty(PropertyName = "logging_enabled")]
        public bool? LoggingEnabled { get; set; }
    }
}
