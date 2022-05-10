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
    public class NSXTVtepTableCsvRecordType : NSXTCsvRecordType
    {
        /// <summary>
        /// The virtual tunnel endpoint label
        /// </summary>
        [JsonProperty(PropertyName = "vtep_label", Required = Required.AllowNull)]
        public long VtepLabel { get; set; }
        /// <summary>
        /// The virtual tunnel endpoint MAC address
        /// </summary>
        [JsonProperty(PropertyName = "vtep_mac_address", Required = Required.AllowNull)]
        public string VtepMacAddress { get; set; }
        /// <summary>
        /// The virtual tunnel endpoint IP address
        /// </summary>
        [JsonProperty(PropertyName = "vtep_ip")]
        public string? VtepIp { get; set; }
        /// <summary>
        /// The segment Id
        /// </summary>
        [JsonProperty(PropertyName = "segment_id")]
        public string? SegmentId { get; set; }
    }
}
