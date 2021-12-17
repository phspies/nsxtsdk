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
    public class NSXTSegmentPortMacTableEntryType 
    {
        public NSXTSegmentPortMacTableEntryType()
        {
        }
        /// <summary>
        /// The type of the MAC address
        /// </summary>
        [JsonProperty(PropertyName = "mac_type", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"The type of the MAC address")]
        [System.ComponentModel.DataAnnotations.Required]
        public NSXTSegmentPortMacTableEntryMacTypeEnumType MacType { get; set; }
        /// <summary>
        /// The MAC address
        /// </summary>
        [JsonProperty(PropertyName = "mac_address", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"The MAC address")]
        [System.ComponentModel.DataAnnotations.Required]
        public string MacAddress { get; set; }
    }
}
