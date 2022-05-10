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
    /// Advanced load balancer L4RuleActionSelectPool object
    /// </summary>
    [NSXTProperty(Description: @"Advanced load balancer L4RuleActionSelectPool object")]
    public class NSXTALBL4RuleActionSelectPoolType 
    {
        /// <summary>
        /// ID of the pool of servers to serve the request.
        /// It is a reference to an object of type Pool.
        /// </summary>
        [JsonProperty(PropertyName = "pool_path")]
        public string? PoolPath { get; set; }
        /// <summary>
        /// Indicates action to take on rule match.
        /// Enum options - L4_RULE_ACTION_SELECT_POOL,
        /// L4_RULE_ACTION_SELECT_POOLGROUP.
        /// Allowed in Basic(Allowed values-
        /// L4_RULE_ACTION_SELECT_POOL) edition, Essentials(Allowed
        /// values- L4_RULE_ACTION_SELECT_POOL) edition, Enterprise
        /// edition.
        /// </summary>
        [JsonProperty(PropertyName = "action_type", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTALBL4RuleActionSelectPoolActionTypeEnumType ActionType { get; set; }
        /// <summary>
        /// ID of the pool group to serve the request.
        /// It is a reference to an object of type PoolGroup.
        /// Allowed in Basic edition, Essentials edition, Enterprise
        /// edition.
        /// </summary>
        [JsonProperty(PropertyName = "pool_group_path")]
        public string? PoolGroupPath { get; set; }
    }
}
