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
    public class NSXTSupportBundleContainerNodeType 
    {
        public NSXTSupportBundleContainerNodeType()
        {
        }
        /// <summary>
        /// Support bundle container type
        /// </summary>
        [JsonProperty(PropertyName = "container_type", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"Support bundle container type")]
        [System.ComponentModel.DataAnnotations.Required]
        public NSXTSupportBundleContainerNodeContainerTypeEnumType ContainerType { get; set; }
    }
}
