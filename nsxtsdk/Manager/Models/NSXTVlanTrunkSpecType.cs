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
    /// VlanTrunkspec is used for specifying trunk VLAN id ranges.
    /// </summary>
    [NSXTProperty(Description: @"VlanTrunkspec is used for specifying trunk VLAN id ranges.")]
    public class NSXTVlanTrunkSpecType 
    {
        /// <summary>
        /// Trunk VLAN id ranges
        /// </summary>
        [JsonProperty(PropertyName = "vlan_ranges", Required = Required.AllowNull)]
        public IList<NSXTTrunkVlanRangeType> VlanRanges { get; set; }
    }
}
