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
    public class NSXTAllocationBasedOnFailureDomainType : NSXTAllocationRuleActionType
    {
        /// <summary>
        /// Enable placement algorithm to consider failure domain of edge transport
        /// nodes and place active and standby contexts in different failure domains.
        /// </summary>
        [JsonProperty(PropertyName = "enabled")]
        public bool? Enabled { get; set; }
    }
}
