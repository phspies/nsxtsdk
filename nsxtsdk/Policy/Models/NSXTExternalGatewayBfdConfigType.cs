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
    /// Configuration for BFD session between host nodes and external gateways.
        /// If this configuration is not provided, system defaults are applied.
    /// </summary>
    [NSXTProperty(Description: @"Configuration for BFD session between host nodes and external gateways.If this configuration is not provided, system defaults are applied.")]
    public class NSXTExternalGatewayBfdConfigType 
    {
        /// <summary>
        /// Policy path to Bfd Profile
        /// </summary>
        [JsonProperty(PropertyName = "bfd_profile_path")]
        public string? BfdProfilePath { get; set; }
        /// <summary>
        /// Flag to enable BFD session.
        /// </summary>
        [JsonProperty(PropertyName = "enable")]
        public bool? Enable { get; set; }
    }
}
