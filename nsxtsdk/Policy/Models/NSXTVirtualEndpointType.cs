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
    public class NSXTVirtualEndpointType : NSXTBaseEndpointType
    {
        /// <summary>
        /// One VirtualEndpoint will be created per service name.
        /// </summary>
        [JsonProperty(PropertyName = "service_names", Required = Required.AllowNull)]
        public IList<string> ServiceNames { get; set; }
    }
}
