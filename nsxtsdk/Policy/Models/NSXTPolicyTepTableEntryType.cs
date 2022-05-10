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
    public class NSXTPolicyTepTableEntryType 
    {
        /// <summary>
        /// The tunnel endpoint label
        /// </summary>
        [JsonProperty(PropertyName = "tep_label")]
        public long? TepLabel { get; set; }
        /// <summary>
        /// The segment Id
        /// </summary>
        [JsonProperty(PropertyName = "segment_id")]
        public string? SegmentId { get; set; }
        /// <summary>
        /// The tunnel endpoint MAC address
        /// </summary>
        [JsonProperty(PropertyName = "tep_mac_address")]
        public string? TepMacAddress { get; set; }
        /// <summary>
        /// The tunnel endpoint IP address
        /// </summary>
        [JsonProperty(PropertyName = "tep_ip")]
        public string? TepIp { get; set; }
    }
}
