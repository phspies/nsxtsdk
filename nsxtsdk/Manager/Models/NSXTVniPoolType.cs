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
    public class NSXTVniPoolType : NSXTManagedResourceType
    {
        public NSXTVniPoolType()
        {
        }
        /// <summary>
        /// VNI range list results
        /// </summary>
        [JsonProperty(PropertyName = "ranges", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"VNI range list results")]
        [System.ComponentModel.DataAnnotations.Required]
        public IList<NSXTVniRangeType> Ranges { get; set; }
    }
}
