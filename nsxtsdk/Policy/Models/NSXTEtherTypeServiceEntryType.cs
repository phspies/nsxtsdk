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
    public class NSXTEtherTypeServiceEntryType : NSXTServiceEntryType
    {
        /// <summary>
        /// Type of the encapsulated protocol
        /// </summary>
        [JsonProperty(PropertyName = "ether_type", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"Type of the encapsulated protocol")]
        [System.ComponentModel.DataAnnotations.Required]
        public long EtherType { get; set; }
    }
}