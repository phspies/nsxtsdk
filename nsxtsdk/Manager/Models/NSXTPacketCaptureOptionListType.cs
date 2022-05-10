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
    public class NSXTPacketCaptureOptionListType : NSXTListResultType
    {
        /// <summary>
        /// Packet capture option collection
        /// </summary>
        [JsonProperty(PropertyName = "values")]
        public IList<NSXTPacketCaptureOptionType> Values { get; set; }
    }
}
