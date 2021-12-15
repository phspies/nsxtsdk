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
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTMacPoolType : NSXTManagedResourceType
    {
        /// <summary>
        /// Array of ranges for MAC addresses
        /// </summary>
        [JsonProperty(PropertyName = "ranges", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"Array of ranges for MAC addresses")]
        [System.ComponentModel.DataAnnotations.Required]
        public IList<NSXTMacRangeType> Ranges { get; set; }
    }
}
