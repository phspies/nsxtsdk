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
    /// It represent the resource with details of name and fields it owns.
    /// </summary>
    [NSXTProperty(Description: @"It represent the resource with details of name and fields it owns.")]
    public class NSXTPolicyFineTuningResourceInfoType 
    {
        /// <summary>
        /// List of all field of any resource
        /// </summary>
        [JsonProperty(PropertyName = "fields", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"List of all field of any resource")]
        [System.ComponentModel.DataAnnotations.Required]
        public IList<NSXTPolicyFineTuningResourceInfoDetailType> Fields { get; set; }
        /// <summary>
        /// It will represent resource with name and fields.
        /// </summary>
        [JsonProperty(PropertyName = "resource_name", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"It will represent resource with name and fields.")]
        [System.ComponentModel.DataAnnotations.Required]
        public string ResourceName { get; set; }
    }
}
