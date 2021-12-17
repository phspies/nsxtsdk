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
    /// Define action for each allocation rule which added on edge cluster.
    /// </summary>
    [NSXTProperty(Description: @"Define action for each allocation rule which added on edge cluster.")]
    public class NSXTAllocationRuleActionType 
    {
        public NSXTAllocationRuleActionType()
        {
        }
        /// <summary>
        /// Set action for each allocation rule on edge cluster which will help in
        /// auto placement.
        /// </summary>
        [JsonProperty(PropertyName = "action_type", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"Set action for each allocation rule on edge cluster which will help inauto placement.")]
        [System.ComponentModel.DataAnnotations.Required]
        public NSXTAllocationRuleActionActionTypeEnumType ActionType { get; set; }
    }
}
