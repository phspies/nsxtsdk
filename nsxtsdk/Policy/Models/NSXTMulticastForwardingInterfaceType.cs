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
    /// Multicast forwarding interface details.
    /// </summary>
    [NSXTProperty(Description: @"Multicast forwarding interface details.")]
    public class NSXTMulticastForwardingInterfaceType 
    {
        /// <summary>
        /// Interface id.
        /// </summary>
        [JsonProperty(PropertyName = "ifuid")]
        public string? Ifuid { get; set; }
    }
}
