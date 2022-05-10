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
    /// The option is used to filter data on given node.
    /// </summary>
    [NSXTProperty(Description: @"The option is used to filter data on given node.")]
    public class NSXTPacketCaptureOptionType 
    {
        /// <summary>
        /// The avaiable option names in the enum can be used to filter the capture data.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTPacketCaptureOptionNameEnumType? Name { get; set; }
        /// <summary>
        /// Define the capture value according to the given capture option.
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public string? Value { get; set; }
    }
}
