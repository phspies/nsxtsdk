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

namespace nsxtsdk.ManagerModels
{
    /// <summary>
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTAllocationBasedOnFailureDomainType : NSXTAllocationRuleActionType
    {
        public NSXTAllocationBasedOnFailureDomainType()
        {
        }
        /// <summary>
        /// Enable placement algorithm to consider failure domain of edge transport
        /// nodes and place active and standby contexts in different failure domains.
        /// </summary>
        [JsonProperty(PropertyName = "enabled")]
        [NSXTProperty(IsRequired: false, Description: @"Enable placement algorithm to consider failure domain of edge transportnodes and place active and standby contexts in different failure domains.")]
        public bool? Enabled { get; set; }
    }
}
