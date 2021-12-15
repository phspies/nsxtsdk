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
    /// Object to identify an uplink based on its type and name
    /// </summary>
    [NSXTProperty(Description: @"Object to identify an uplink based on its type and name")]
    public class NSXTUplinkType 
    {
        /// <summary>
        /// Name of this uplink
        /// </summary>
        [JsonProperty(PropertyName = "uplink_name", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"Name of this uplink")]
        [System.ComponentModel.DataAnnotations.Required]
        public string UplinkName { get; set; }
        /// <summary>
        /// Type of the uplink
        /// </summary>
        [JsonProperty(PropertyName = "uplink_type", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"Type of the uplink")]
        [System.ComponentModel.DataAnnotations.Required]
        public NSXTUplinkUplinkTypeEnumType UplinkType { get; set; }
    }
}
