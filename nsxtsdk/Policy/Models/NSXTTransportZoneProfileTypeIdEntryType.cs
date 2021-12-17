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

namespace nsxtsdk.PolicyModels
{
    /// <summary>
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTTransportZoneProfileTypeIdEntryType 
    {
        public NSXTTransportZoneProfileTypeIdEntryType()
        {
        }
        /// <summary>
        /// profile id of the resource type
        /// </summary>
        [JsonProperty(PropertyName = "profile_id", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"profile id of the resource type")]
        [System.ComponentModel.DataAnnotations.Required]
        public string ProfileId { get; set; }
        /// <summary>
        /// Selects the type of the transport zone profile
        /// </summary>
        [JsonProperty(PropertyName = "resource_type")]
        [NSXTProperty(IsRequired: false, Description: @"Selects the type of the transport zone profile")]
        public NSXTTransportZoneProfileTypeIdEntryResourceTypeEnumType? ResourceType { get; set; }
    }
}
