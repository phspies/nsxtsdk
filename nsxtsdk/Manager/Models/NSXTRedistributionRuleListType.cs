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
    public class NSXTRedistributionRuleListType : NSXTManagedResourceType
    {
        /// <summary>
        /// List of redistribution rules.
        /// User needs to re-order rules to change the priority.
        /// </summary>
        [JsonProperty(PropertyName = "rules")]
        public IList<NSXTRedistributionRuleType> Rules { get; set; }
        /// <summary>
        /// Logical router id
        /// </summary>
        [JsonProperty(PropertyName = "logical_router_id")]
        public string? LogicalRouterId { get; set; }
    }
}
