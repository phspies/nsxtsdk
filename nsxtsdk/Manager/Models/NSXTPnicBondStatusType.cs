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
    /// pNIC/bond statuses
    /// </summary>
    [NSXTProperty(Description: @"pNIC/bond statuses")]
    public class NSXTPnicBondStatusType 
    {
        public NSXTPnicBondStatusType()
        {
        }
        /// <summary>
        /// Status of pNIC/bond
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        [NSXTProperty(IsRequired: false, Description: @"Status of pNIC/bond")]
        public NSXTPnicBondStatusStatusEnumType? Status { get; set; }
        /// <summary>
        /// type, whether the object is a pNIC or a bond
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        [NSXTProperty(IsRequired: false, Description: @"type, whether the object is a pNIC or a bond")]
        public NSXTPnicBondStatusTypeEnumType? Type { get; set; }
        /// <summary>
        /// Name of the pNIC/bond
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        [NSXTProperty(IsRequired: false, Description: @"Name of the pNIC/bond")]
        public string? Name { get; set; }
    }
}
