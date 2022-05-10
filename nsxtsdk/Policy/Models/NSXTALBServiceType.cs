using nsxtsdk.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.ComponentModel;
using NJsonSchema.Converters;
using Newtonsoft.Json.Converters;

namespace nsxtsdk.PolicyModels
{
    /// <summary>
    /// Advanced load balancer Service object
    /// </summary>
    [NSXTProperty(Description: @"Advanced load balancer Service object")]
    public class NSXTALBServiceType 
    {
        /// <summary>
        /// Enable SSL termination and offload for traffic from
        /// clients.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as false.
        /// </summary>
        [JsonProperty(PropertyName = "enable_ssl")]
        public bool? EnableSsl { get; set; }
        /// <summary>
        /// The end of the Virtual Service's port number range.
        /// Allowed values are 1-65535.
        /// Special values are 0- 'single port'.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as 0.
        /// </summary>
        [JsonProperty(PropertyName = "port_range_end")]
        public long? PortRangeEnd { get; set; }
        /// <summary>
        /// Override the network profile for this specific service
        /// port.
        /// It is a reference to an object of type NetworkProfile.
        /// </summary>
        [JsonProperty(PropertyName = "override_network_profile_path")]
        public string? OverrideNetworkProfilePath { get; set; }
        /// <summary>
        /// Enable application layer specific features for the this
        /// specific service.
        /// It is a reference to an object of type ApplicationProfile.
        /// Allowed in Basic edition, Essentials edition, Enterprise
        /// edition.
        /// </summary>
        [JsonProperty(PropertyName = "override_application_profile_path")]
        public string? OverrideApplicationProfilePath { get; set; }
        /// <summary>
        /// The Virtual Service's port number.
        /// Allowed values are 0-65535.
        /// </summary>
        [JsonProperty(PropertyName = "port", Required = Required.AllowNull)]
        public long Port { get; set; }
        /// <summary>
        /// Enable HTTP2 on this port.
        /// Allowed in Basic(Allowed values- false) edition,
        /// Essentials(Allowed values- false) edition, Enterprise
        /// edition.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as false.
        /// </summary>
        [JsonProperty(PropertyName = "enable_http2")]
        public bool? EnableHttp2 { get; set; }
    }
}
