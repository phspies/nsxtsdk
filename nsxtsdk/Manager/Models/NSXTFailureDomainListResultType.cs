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
    public class NSXTFailureDomainListResultType : NSXTListResultType
    {
        /// <summary>
        /// Array of all failure domains including system generated default
        /// failure domain
        /// </summary>
        [JsonProperty(PropertyName = "results", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"Array of all failure domains including system generated defaultfailure domain")]
        [System.ComponentModel.DataAnnotations.Required]
        public IList<NSXTFailureDomainType> Results { get; set; }
    }
}