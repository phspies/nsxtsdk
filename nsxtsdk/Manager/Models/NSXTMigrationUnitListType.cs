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
    public class NSXTMigrationUnitListType 
    {
        /// <summary>
        /// Collection of Migration units
        /// </summary>
        [JsonProperty(PropertyName = "list", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"Collection of Migration units")]
        [System.ComponentModel.DataAnnotations.Required]
        public IList<NSXTMigrationUnitType> List { get; set; }
    }
}
