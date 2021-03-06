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
    public class NSXTNodeServicePropertiesType : NSXTResourceType
    {
        /// <summary>
        /// Service name
        /// </summary>
        [JsonProperty(PropertyName = "service_name", Required = Required.AllowNull)]
        public string ServiceName { get; set; }
    }
}
