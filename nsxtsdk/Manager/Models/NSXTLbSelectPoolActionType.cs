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
    public class NSXTLbSelectPoolActionType : NSXTLbRuleActionType
    {
        /// <summary>
        /// Display name of load balancer pool
        /// </summary>
        [JsonProperty(PropertyName = "pool_name")]
        public string? PoolName { get; set; }
        /// <summary>
        /// UUID of load balancer pool
        /// </summary>
        [JsonProperty(PropertyName = "pool_id", Required = Required.AllowNull)]
        public string PoolId { get; set; }
    }
}
