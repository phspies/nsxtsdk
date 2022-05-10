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
    /// Advanced load balancer HealthMonitorRadius object
    /// </summary>
    [NSXTProperty(Description: @"Advanced load balancer HealthMonitorRadius object")]
    public class NSXTALBHealthMonitorRadiusType 
    {
        /// <summary>
        /// Radius monitor will query Radius server with this username.
        /// </summary>
        [JsonProperty(PropertyName = "username", Required = Required.AllowNull)]
        public string Username { get; set; }
        /// <summary>
        /// Radius monitor will query Radius server with this password.
        /// </summary>
        [JsonProperty(PropertyName = "password")]
        public string? Password { get; set; }
        /// <summary>
        /// Radius monitor will query Radius server with this shared
        /// secret.
        /// </summary>
        [JsonProperty(PropertyName = "shared_secret")]
        public string? SharedSecret { get; set; }
    }
}
