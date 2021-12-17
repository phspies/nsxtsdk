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
    /// Resource metadata.
    /// </summary>
    [NSXTProperty(Description: @"Resource metadata.")]
    public class NSXTMPResourceMetadataType 
    {
        public NSXTMPResourceMetadataType()
        {
        }
        /// <summary>
        /// Resource metadata value.
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        [NSXTProperty(IsRequired: false, Description: @"Resource metadata value.")]
        public string? Value { get; set; }
        /// <summary>
        /// It has to be one of the attribute of targeted policy intent.
        /// </summary>
        [JsonProperty(PropertyName = "key", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"It has to be one of the attribute of targeted policy intent.")]
        [System.ComponentModel.DataAnnotations.Required]
        public string Key { get; set; }
    }
}
