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
    public class NSXTMirrorDestinationType 
    {
        public NSXTMirrorDestinationType()
        {
        }
        /// <summary>
        /// Resource types of mirror destination
        /// </summary>
        [JsonProperty(PropertyName = "resource_type", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"Resource types of mirror destination")]
        [System.ComponentModel.DataAnnotations.Required]
        public NSXTMirrorDestinationResourceTypeEnumType ResourceType { get; set; }
    }
}
