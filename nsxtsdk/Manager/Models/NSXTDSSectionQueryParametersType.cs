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
    /// Section query parameters
    /// </summary>
    [NSXTProperty(Description: @"Section query parameters")]
    public class NSXTDSSectionQueryParametersType 
    {
        /// <summary>
        /// Flag to cascade delete of this object to all it's child objects.
        /// </summary>
        [JsonProperty(PropertyName = "cascade")]
        [NSXTProperty(IsRequired: false, Description: @"Flag to cascade delete of this object to all it&apos;s child objects.")]
        public bool? Cascade { get; set; }
    }
}