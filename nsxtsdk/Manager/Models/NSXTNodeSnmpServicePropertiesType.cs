using nsxtsdk.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.ComponentModel;
using NJsonSchema.Converters;
using Newtonsoft.Json.Converters;

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
