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
    public class NSXTLbRuleType : NSXTManagedResourceType
    {
        /// <summary>
        /// Each load balancer rule is used at a specific phase of load balancer
        /// processing. Currently five phases are supported, HTTP_REQUEST_REWRITE,
        /// HTTP_FORWARDING, HTTP_RESPONSE_REWRITE, HTTP_ACCESS and TRANSPORT.
        /// When an HTTP request message is received by load balancer, all
        /// HTTP_REQUEST_REWRITE rules, if present are executed in the order they
        /// are applied to virtual server. And then if HTTP_FORWARDING rules
        /// present, only first matching rule's action is executed, remaining rules
        /// are not checked. HTTP_FORWARDING rules can have only one action. If the
        /// request is forwarded to a backend server and the response goes back to
        /// load balancer, all HTTP_RESPONSE_REWRITE rules, if present, are executed
        /// in the order they are applied to the virtual server.
        /// In HTTP_ACCESS phase, user can define action to control access using
        /// JWT authentication.
        /// In TRANSPORT phase, user can define the condition to match SNI in TLS
        /// client hello and define the action to do SSL end-to-end, SSL offloading
        /// or SSL passthrough using a specific load balancer server pool.
        /// </summary>
        [JsonProperty(PropertyName = "phase", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTLbRulePhaseEnumType Phase { get; set; }
        /// <summary>
        /// A list of match conditions used to match application traffic. Multiple
        /// match conditions can be specified in one load balancer rule, each match
        /// condition defines a criterion to match application traffic.
        /// If no match conditions are specified, then the load balancer rule will
        /// always match and it is used typically to define default rules. If more
        /// than one match condition is specified, then match strategy determines
        /// if all conditions should match or any one condition should match for the
        /// load balancer rule to considered a match.
        /// </summary>
        [JsonProperty(PropertyName = "match_conditions")]
        public IList<NSXTLbRuleConditionType> MatchConditions { get; set; }
        /// <summary>
        /// A list of actions to be executed at specified phase when load balancer
        /// rule matches. The actions are used to manipulate application traffic,
        /// such as rewrite URI of HTTP messages, redirect HTTP messages, etc.
        /// </summary>
        [JsonProperty(PropertyName = "actions", Required = Required.AllowNull)]
        public IList<NSXTLbRuleActionType> Actions { get; set; }
        /// <summary>
        /// Strategy to define how load balancer rule is considered a match when
        /// multiple match conditions are specified in one rule. If match_stragety
        /// is set to ALL, then load balancer rule is considered a match only if all
        /// the conditions match. If match_strategy is set to ANY, then load
        /// balancer rule is considered a match if any one of the conditions match.
        /// </summary>
        [JsonProperty(PropertyName = "match_strategy", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTLbRuleMatchStrategyEnumType MatchStrategy { get; set; }
    }
}
