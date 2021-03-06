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
    /// Define action for each allocation rule which added on edge cluster.
    /// </summary>
    [NSXTProperty(Description: @"Define action for each allocation rule which added on edge cluster.")]
    public class NSXTAllocationRuleActionType 
    {
        /// <summary>
        /// Set action for each allocation rule on edge cluster which will help in
        /// auto placement.
        /// </summary>
        [JsonProperty(PropertyName = "action_type", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTAllocationRuleActionActionTypeEnumType ActionType { get; set; }
    }
}
