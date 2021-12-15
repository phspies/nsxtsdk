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

namespace nsxtsdk.PolicyModels
{
    /// <summary>
    /// Advanced load balancer HealthMonitorUdp object
    /// </summary>
    [NSXTProperty(Description: @"Advanced load balancer HealthMonitorUdp object")]
    public class NSXTALBHealthMonitorUdpType 
    {
        /// <summary>
        /// Match or look for this keyword in the first 2KB of server's
        /// response indicating server maintenance.
        /// A successful match results in the server being marked down.
        /// </summary>
        [JsonProperty(PropertyName = "maintenance_response")]
        [NSXTProperty(IsRequired: false, Description: @"Match or look for this keyword in the first 2KB of server&apos;sresponse indicating server maintenance.A successful match results in the server being marked down.")]
        public string? MaintenanceResponse { get; set; }
        /// <summary>
        /// Send UDP request.
        /// </summary>
        [JsonProperty(PropertyName = "udp_request")]
        [NSXTProperty(IsRequired: false, Description: @"Send UDP request.")]
        public string? UdpRequest { get; set; }
        /// <summary>
        /// Match for keyword in the UDP response.
        /// </summary>
        [JsonProperty(PropertyName = "udp_response")]
        [NSXTProperty(IsRequired: false, Description: @"Match for keyword in the UDP response.")]
        public string? UdpResponse { get; set; }
    }
}