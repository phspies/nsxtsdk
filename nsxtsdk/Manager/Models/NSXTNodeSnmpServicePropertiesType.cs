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
    public class NSXTNodeSnmpServicePropertiesType : NSXTNodeServicePropertiesType
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "service_properties", Required = Required.AllowNull)]
        public NSXTSnmpServicePropertiesType ServiceProperties { get; set; }
    }
}
