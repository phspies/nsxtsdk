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
    public class NSXTNodeProtonServicePropertiesType : NSXTNodeServicePropertiesType
    {
        /// <summary>
        /// Service properties
        /// </summary>
        [JsonProperty(PropertyName = "service_properties")]
        [NSXTProperty(IsRequired: false, Description: @"Service properties")]
        public NSXTLoggingServicePropertiesType ServiceProperties { get; set; }
    }
}
