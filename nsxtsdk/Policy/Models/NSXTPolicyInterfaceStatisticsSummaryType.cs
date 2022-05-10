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
    public class NSXTPolicyInterfaceStatisticsSummaryType : NSXTLogicalRouterPortStatisticsSummaryType
    {
        /// <summary>
        /// Policy path for the interface
        /// </summary>
        [JsonProperty(PropertyName = "interface_policy_path")]
        public string? InterfacePolicyPath { get; set; }
    }
}
