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
    /// Vidm Info
    /// </summary>
    [NSXTProperty(Description: @"Vidm Info")]
    public class NSXTVidmInfoType 
    {
        /// <summary>
        /// User's Full Name Or User Group's Display Name
        /// </summary>
        [JsonProperty(PropertyName = "display_name")]
        public string? DisplayName { get; set; }
        /// <summary>
        /// Type
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTVidmInfoTypeEnumType? Type { get; set; }
        /// <summary>
        /// Username Or Groupname
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string? Name { get; set; }
    }
}
