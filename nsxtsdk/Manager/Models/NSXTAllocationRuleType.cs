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
    /// Allocation rule on edge cluster which will be considered in auto placement
        /// of TIER1 logical routers, DHCP and MDProxy.
    /// </summary>
    [NSXTProperty(Description: @"Allocation rule on edge cluster which will be considered in auto placementof TIER1 logical routers, DHCP and MDProxy.")]
    public class NSXTAllocationRuleType 
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "action", Required = Required.AllowNull)]
        public NSXTAllocationRuleActionType Action { get; set; }
    }
}
