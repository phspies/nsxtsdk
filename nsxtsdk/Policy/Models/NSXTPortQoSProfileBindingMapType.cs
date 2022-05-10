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
    public class NSXTPortQoSProfileBindingMapType : NSXTQoSProfileBindingMapType
    {
        /// <summary>
        /// PolicyPath of associated  QoS Profile
        /// </summary>
        [JsonProperty(PropertyName = "qos_profile_path")]
        public string? QosProfilePath { get; set; }
    }
}
