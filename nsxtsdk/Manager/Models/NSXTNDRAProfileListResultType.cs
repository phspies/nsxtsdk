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
    public class NSXTNDRAProfileListResultType : NSXTListResultType
    {
        public NSXTNDRAProfileListResultType()
        {
        }
        /// <summary>
        /// Paginated list of NDRAProfile
        /// </summary>
        [JsonProperty(PropertyName = "results", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"Paginated list of NDRAProfile")]
        [System.ComponentModel.DataAnnotations.Required]
        public IList<NSXTNDRAProfileType> Results { get; set; }
    }
}
