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
    /// Advanced load balancer NetworkFilter object
    /// </summary>
    [NSXTProperty(Description: @"Advanced load balancer NetworkFilter object")]
    public class NSXTALBNetworkFilterType 
    {
        /// <summary>
        /// server_filter of NetworkFilter.
        /// </summary>
        [JsonProperty(PropertyName = "server_filter")]
        public string? ServerFilter { get; set; }
    }
}
