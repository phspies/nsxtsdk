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
    /// Vidm Info
    /// </summary>
    [NSXTProperty(Description: @"Vidm Info")]
    public class NSXTVidmInfoType 
    {
        /// <summary>
        /// User's Full Name Or User Group's Display Name
        /// </summary>
        [JsonProperty(PropertyName = "display_name")]
        [NSXTProperty(IsRequired: false, Description: @"User&apos;s Full Name Or User Group&apos;s Display Name")]
        public string? DisplayName { get; set; }
        /// <summary>
        /// Type
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        [NSXTProperty(IsRequired: false, Description: @"Type")]
        public NSXTVidmInfoTypeEnumType? Type { get; set; }
        /// <summary>
        /// Username Or Groupname
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        [NSXTProperty(IsRequired: false, Description: @"Username Or Groupname")]
        public string? Name { get; set; }
    }
}