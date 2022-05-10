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
    /// Details about the AVI LB endpoint
    /// </summary>
    [NSXTProperty(Description: @"Details about the AVI LB endpoint")]
    public class NSXTAviEndPointType 
    {
        /// <summary>
        /// Username for AVI LB endpoint.
        /// </summary>
        [JsonProperty(PropertyName = "avi_endpoint_username", Required = Required.AllowNull)]
        public string AviEndpointUsername { get; set; }
        /// <summary>
        /// AVI LB endpoint port.
        /// </summary>
        [JsonProperty(PropertyName = "avi_endpoint_port")]
        public int? AviEndpointPort { get; set; }
        /// <summary>
        /// IP address of the AVI LB endpoint.
        /// </summary>
        [JsonProperty(PropertyName = "avi_endpoint_ip", Required = Required.AllowNull)]
        public string AviEndpointIp { get; set; }
        /// <summary>
        /// Password for AVI LB endpoint.
        /// </summary>
        [JsonProperty(PropertyName = "avi_endpoint_password")]
        public string? AviEndpointPassword { get; set; }
    }
}
