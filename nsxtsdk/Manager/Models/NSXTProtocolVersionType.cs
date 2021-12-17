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
    /// TLS protocol version
    /// </summary>
    [NSXTProperty(Description: @"TLS protocol version")]
    public class NSXTProtocolVersionType 
    {
        public NSXTProtocolVersionType()
        {
        }
        /// <summary>
        /// Enable status for this protocol version
        /// </summary>
        [JsonProperty(PropertyName = "enabled", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"Enable status for this protocol version")]
        [System.ComponentModel.DataAnnotations.Required]
        public bool Enabled { get; set; }
        /// <summary>
        /// Name of the TLS protocol version
        /// </summary>
        [JsonProperty(PropertyName = "name", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"Name of the TLS protocol version")]
        [System.ComponentModel.DataAnnotations.Required]
        public string Name { get; set; }
    }
}
