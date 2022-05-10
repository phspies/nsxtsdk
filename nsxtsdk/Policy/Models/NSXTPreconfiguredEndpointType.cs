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
    /// Tunnel endpoint configuration of preconfigured host switch
    /// </summary>
    [NSXTProperty(Description: @"Tunnel endpoint configuration of preconfigured host switch")]
    public class NSXTPreconfiguredEndpointType 
    {
        /// <summary>
        /// Name of the virtual tunnel endpoint
        /// </summary>
        [JsonProperty(PropertyName = "device_name", Required = Required.AllowNull)]
        public string DeviceName { get; set; }
    }
}
