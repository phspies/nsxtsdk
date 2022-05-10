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
    public class NSXTDADProfileType : NSXTManagedResourceType
    {
        /// <summary>
        /// The time duration in seconds, to wait for Neighbor advertisement
        /// after sending the Neighbor solicitation message.
        /// </summary>
        [JsonProperty(PropertyName = "wait_time")]
        public long? WaitTime { get; set; }
        /// <summary>
        /// Number of Neighbor solicitation packets generated before completing the
        /// Duplicate address detection process.
        /// </summary>
        [JsonProperty(PropertyName = "ns_retries")]
        public long? NsRetries { get; set; }
        /// <summary>
        /// DAD Mode
        /// </summary>
        [JsonProperty(PropertyName = "dad_mode")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTDadprofileDadModeEnumType? DadMode { get; set; }
    }
}
