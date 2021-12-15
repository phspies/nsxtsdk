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
        [NSXTProperty(IsRequired: true, Description: @"Virtual IP address, 0.0.0.0 if not configured")]
        [System.ComponentModel.DataAnnotations.Required]
        public string IpAddress { get; set; }
    }
}