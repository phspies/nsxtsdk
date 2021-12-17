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
    /// VlanTrunkspec is used for specifying trunk VLAN id ranges.
    /// </summary>
    [NSXTProperty(Description: @"VlanTrunkspec is used for specifying trunk VLAN id ranges.")]
    public class NSXTVlanTrunkSpecType 
    {
        public NSXTVlanTrunkSpecType()
        {
        }
        /// <summary>
        /// Trunk VLAN id ranges
        /// </summary>
        [JsonProperty(PropertyName = "vlan_ranges", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"Trunk VLAN id ranges")]
        [System.ComponentModel.DataAnnotations.Required]
        public IList<NSXTTrunkVlanRangeType> VlanRanges { get; set; }
    }
}
