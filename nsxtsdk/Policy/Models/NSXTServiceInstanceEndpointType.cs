using nsxtsdk.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.ComponentModel;
using NJsonSchema.Converters;
using Newtonsoft.Json.Converters;

namespace nsxtsdk.PolicyModels
{
    /// <summary>
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTServiceInstanceEndpointType : NSXTBaseEndpointType
    {
        /// <summary>
        /// Path of Service Interface to which this ServiceInstanceEndpoint is connected.
        /// </summary>
        [JsonProperty(PropertyName = "service_interface_path", Required = Required.AllowNull)]
        public string ServiceInterfacePath { get; set; }
    }
}
