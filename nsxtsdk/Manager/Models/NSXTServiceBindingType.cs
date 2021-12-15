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
    public class NSXTServiceBindingType 
    {
        /// <summary>
        /// Identifier of Logical Service
        /// </summary>
        [JsonProperty(PropertyName = "service_id", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"Identifier of Logical Service")]
        [System.ComponentModel.DataAnnotations.Required]
        public NSXTResourceReferenceType ServiceId { get; set; }
    }
}
