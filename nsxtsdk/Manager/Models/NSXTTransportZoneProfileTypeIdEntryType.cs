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
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTTransportZoneProfileTypeIdEntryType 
    {
        /// <summary>
        /// profile id of the resource type
        /// </summary>
        [JsonProperty(PropertyName = "profile_id", Required = Required.AllowNull)]
        public string ProfileId { get; set; }
        /// <summary>
        /// Selects the type of the transport zone profile
        /// </summary>
        [JsonProperty(PropertyName = "resource_type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTTransportZoneProfileTypeIdEntryResourceTypeEnumType? ResourceType { get; set; }
    }
}
