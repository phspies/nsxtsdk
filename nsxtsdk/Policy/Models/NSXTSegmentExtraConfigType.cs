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
    /// Segment extra config is intended for supporting vendor specific configuration on the
        /// data path, it can be set as key value string pairs on either segment or segment port.
    /// </summary>
    [NSXTProperty(Description: @"Segment extra config is intended for supporting vendor specific configuration on thedata path, it can be set as key value string pairs on either segment or segment port.")]
    public class NSXTSegmentExtraConfigType 
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "config_pair", Required = Required.AllowNull)]
        public NSXTUnboundedKeyValuePairType ConfigPair { get; set; }
    }
}
