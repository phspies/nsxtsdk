// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using nsxtsdk.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using NJsonSchema.Converters;
using System.ComponentModel;

namespace nsxtsdk.PolicyModels
{
    /// <summary>
    /// Binding of a LBPool and Group to a LBVirtualServer
        /// used to route application traffic passing through load balancers.
        /// LBRule uses match conditions to match application traffic passing
        /// through a LBVirtualServer using HTTP or HTTPS. Can bind
        /// multiple LBVirtualServers to a Group. Each LBRule
        /// consists of two optional match conditions, each match contidion defines a
        /// criterion for application traffic.  If no match conditions are
        /// specified, then the LBRule will always match and it is used
        /// typically to define default rules. If more than one match condition is
        /// specified, then matching strategy determines if all conditions should
        /// match or any one condition should match for the LBRule to be
        /// considered a match.  A match indicates that the LBVirtualServer
        /// should route the request to the Group (parent of LBRule).
    /// </summary>
    [NSXTProperty(Description: @"Binding of a LBPool and Group to a LBVirtualServerused to route application traffic passing through load balancers.LBRule uses match conditions to match application traffic passingthrough a LBVirtualServer using HTTP or HTTPS. Can bindmultiple LBVirtualServers to a Group. Each LBRuleconsists of two optional match conditions, each match contidion defines acriterion for application traffic.  If no match conditions arespecified, then the LBRule will always match and it is usedtypically to define default rules. If more than one match condition isspecified, then matching strategy determines if all conditions shouldmatch or any one condition should match for the LBRule to beconsidered a match.  A match indicates that the LBVirtualServershould route the request to the Group (parent of LBRule).")]
    public class NSXTLBRuleType 
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
        [JsonProperty(PropertyName = "phase")]
        [NSXTProperty(IsRequired: false, Description: @"Each load balancer rule is used at a specific phase of load balancerprocessing. Currently five phases are supported, HTTP_REQUEST_REWRITE,HTTP_FORWARDING, HTTP_RESPONSE_REWRITE, HTTP_ACCESS and TRANSPORT.When an HTTP request message is received by load balancer, allHTTP_REQUEST_REWRITE rules, if present are executed in the order theyare applied to virtual server. And then if HTTP_FORWARDING rulespresent, only first matching rule&apos;s action is executed, remaining rulesare not checked. HTTP_FORWARDING rules can have only one action. If therequest is forwarded to a backend server and the response goes back toload balancer, all HTTP_RESPONSE_REWRITE rules, if present, are executedin the order they are applied to the virtual server.In HTTP_ACCESS phase, user can define action to control access usingJWT authentication.In TRANSPORT phase, user can define the condition to match SNI in TLSclient hello and define the action to do SSL end-to-end, SSL offloadingor SSL passthrough using a specific load balancer server pool.")]
        [NSXTDefaultProperty(Default: "HTTP_FORWARDING")]
        public NSXTLbrulePhaseEnumType? Phase { get; set; }
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
        [NSXTProperty(IsRequired: false, Description: @"A list of match conditions used to match application traffic. Multiplematch conditions can be specified in one load balancer rule, each matchcondition defines a criterion to match application traffic.If no match conditions are specified, then the load balancer rule willalways match and it is used typically to define default rules. If morethan one match condition is specified, then match strategy determinesif all conditions should match or any one condition should match for theload balancer rule to considered a match.")]
        public IList<NSXTLBRuleConditionType> MatchConditions { get; set; }
        /// <summary>
        /// A display name useful for identifying an LBRule.
        /// </summary>
        [JsonProperty(PropertyName = "display_name")]
        [NSXTProperty(IsRequired: false, Description: @"A display name useful for identifying an LBRule.")]
        public string? DisplayName { get; set; }
        /// <summary>
        /// A list of actions to be executed at specified phase when load balancer
        /// rule matches. The actions are used to manipulate application traffic,
        /// such as rewrite URI of HTTP messages, redirect HTTP messages, etc.
        /// </summary>
        [JsonProperty(PropertyName = "actions", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"A list of actions to be executed at specified phase when load balancerrule matches. The actions are used to manipulate application traffic,such as rewrite URI of HTTP messages, redirect HTTP messages, etc.")]
        [System.ComponentModel.DataAnnotations.Required]
        public IList<NSXTLBRuleActionType> Actions { get; set; }
        /// <summary>
        /// If more than one match condition is specified, then
        /// matching strategy determines if all conditions should match or any
        /// one condition should match for the LB Rule to be considered a match.
        /// - ALL indicates that both host_match and path_match must match for
        /// this LBRule to be considered a match.
        /// - ANY indicates that either host_match or patch match may match for
        /// this LBRule to be considered a match.
        /// </summary>
        [JsonProperty(PropertyName = "match_strategy")]
        [NSXTProperty(IsRequired: false, Description: @"If more than one match condition is specified, thenmatching strategy determines if all conditions should match or anyone condition should match for the LB Rule to be considered a match.- ALL indicates that both host_match and path_match must match forthis LBRule to be considered a match.- ANY indicates that either host_match or patch match may match forthis LBRule to be considered a match.")]
        [NSXTDefaultProperty(Default: "ANY")]
        public NSXTLbruleMatchStrategyEnumType? MatchStrategy { get; set; }
    }
}