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
    public class NSXTRealizedNSServiceType : NSXTRealizedServiceType
    {
        /// <summary>
        /// Realized nsservice type
        /// </summary>
        [JsonProperty(PropertyName = "service_type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTRealizedNsserviceServiceTypeEnumType? ServiceType { get; set; }
    }
}
