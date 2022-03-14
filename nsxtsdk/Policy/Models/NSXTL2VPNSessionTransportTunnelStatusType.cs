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
    /// Transport tunnel status.
    /// </summary>
    [NSXTProperty(Description: @"Transport tunnel status.")]
    public class NSXTL2VPNSessionTransportTunnelStatusType 
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "resource_type", Required = Required.AllowNull)]
        public NSXTL2VpnsessionTransportTunnelStatusResourceTypeEnumType ResourceType { get; set; }
        /// <summary>
        /// Policy path referencing Transport Tunnel.
        /// </summary>
        public string? TransportTunnelPath { get; set; }
    }
}
