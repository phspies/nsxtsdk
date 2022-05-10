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
    /// Advanced load balancer AuthTacacsPlusAttributeValuePair object
    /// </summary>
    [NSXTProperty(Description: @"Advanced load balancer AuthTacacsPlusAttributeValuePair object")]
    public class NSXTALBAuthTacacsPlusAttributeValuePairType 
    {
        /// <summary>
        /// mandatory.
        /// </summary>
        [JsonProperty(PropertyName = "mandatory")]
        public bool? Mandatory { get; set; }
        /// <summary>
        /// attribute name.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string? Name { get; set; }
        /// <summary>
        /// attribute value.
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public string? Value { get; set; }
    }
}
