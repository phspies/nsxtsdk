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
    public class NSXTLogicalRouterLinkPortOnTIER0Type : NSXTLogicalRouterPortType
    {
        /// <summary>
        /// Logical router port subnets
        /// </summary>
        [JsonProperty(PropertyName = "subnets")]
        public IList<NSXTIPSubnetType> Subnets { get; set; }
        /// <summary>
        /// Identifier of connected LogicalRouterLinkPortOnTIER1 of TIER1 logical router
        /// </summary>
        [JsonProperty(PropertyName = "linked_logical_router_port_id")]
        public string? LinkedLogicalRouterPortId { get; set; }
        /// <summary>
        /// MAC address
        /// </summary>
        [JsonProperty(PropertyName = "mac_address")]
        public string? MacAddress { get; set; }
    }
}
