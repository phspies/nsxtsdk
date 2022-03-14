// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using nsxtsdk.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.ComponentModel;
using NJsonSchema.Converters;

namespace nsxtsdk.ManagerModels
{
    /// <summary>
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTSelectableResourceReferenceType : NSXTResourceReferenceType
    {
        /// <summary>
        /// Set to true if this resource has been selected to be acted upon
        /// </summary>
        [JsonProperty(PropertyName = "selected", Required = Required.AllowNull)]
        public bool Selected { get; set; }
    }
}
