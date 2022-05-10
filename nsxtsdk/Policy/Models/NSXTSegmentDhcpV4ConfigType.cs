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
    public class NSXTSegmentDhcpV4ConfigType : NSXTSegmentDhcpConfigType
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "options")]
        public NSXTDhcpV4OptionsType Options { get; set; }
    }
}
