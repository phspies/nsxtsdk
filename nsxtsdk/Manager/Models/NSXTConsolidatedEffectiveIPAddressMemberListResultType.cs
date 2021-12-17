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
    public class NSXTConsolidatedEffectiveIPAddressMemberListResultType : NSXTListResultType
    {
        public NSXTConsolidatedEffectiveIPAddressMemberListResultType()
        {
        }
        /// <summary>
        /// Paged Collection of site wise consolidated effective ip addresses for the given NSGroup
        /// </summary>
        [JsonProperty(PropertyName = "results", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"Paged Collection of site wise consolidated effective ip addresses for the given NSGroup")]
        [System.ComponentModel.DataAnnotations.Required]
        public IList<NSXTEffectiveIPInfoType> Results { get; set; }
    }
}
