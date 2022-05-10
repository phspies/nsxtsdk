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
    public class NSXTBfdProfileType : NSXTPolicyConfigResourceType
    {
        /// <summary>
        /// Time interval between heartbeat packets in milliseconds.
        /// </summary>
        [JsonProperty(PropertyName = "interval")]
        public int? Interval { get; set; }
        /// <summary>
        /// Declare dead multiple.
        /// Number of times heartbeat packet is missed before BFD declares the
        /// neighbor is down.
        /// </summary>
        [JsonProperty(PropertyName = "multiple")]
        public int? Multiple { get; set; }
    }
}
