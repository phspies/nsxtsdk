// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using nsxtsdk.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.ComponentModel;
using NJsonSchema.Converters;

namespace nsxtsdk.PolicyModels
{
    /// <summary>
    /// OSPF route next hop result.
    /// </summary>
    [NSXTProperty(Description: @"OSPF route next hop result.")]
    public class NSXTOspfRouteNextHopResultType 
    {
        /// <summary>
        /// Check whether OSPF route is directly connected.
        /// </summary>
        public bool? DirectlyAttached { get; set; }
        /// <summary>
        /// OSPF policy interface name.
        /// </summary>
        public string? InterfaceName { get; set; }
        /// <summary>
        /// next-hop address.
        /// </summary>
        public string? NeighborAddress { get; set; }
    }
}
