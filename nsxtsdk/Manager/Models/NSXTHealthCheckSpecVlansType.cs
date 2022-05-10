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
    /// HealthCheckSpecVlan is used for specifying VLAN ID ranges for healthcheck.
    /// </summary>
    [NSXTProperty(Description: @"HealthCheckSpecVlan is used for specifying VLAN ID ranges for healthcheck.")]
    public class NSXTHealthCheckSpecVlansType 
    {
        /// <summary>
        /// VLAN ID ranges
        /// </summary>
        [JsonProperty(PropertyName = "vlan_ranges", Required = Required.AllowNull)]
        public IList<NSXTHealthCheckVlanRangeType> VlanRanges { get; set; }
    }
}
