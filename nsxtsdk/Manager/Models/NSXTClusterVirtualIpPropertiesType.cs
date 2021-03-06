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
    /// Cluster virtual IP properties
    /// </summary>
    [NSXTProperty(Description: @"Cluster virtual IP properties")]
    public class NSXTClusterVirtualIpPropertiesType 
    {
        /// <summary>
        /// Virtual IP address, 0.0.0.0 if not configured
        /// </summary>
        [JsonProperty(PropertyName = "ip_address", Required = Required.AllowNull)]
        public string IpAddress { get; set; }
    }
}
