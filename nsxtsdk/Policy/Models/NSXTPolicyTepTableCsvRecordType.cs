// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using nsxtsdk.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using NJsonSchema.Converters;
using System.ComponentModel;

namespace nsxtsdk.PolicyModels
{
    /// <summary>
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTPolicyTepTableCsvRecordType : NSXTCsvRecordType
    {
        /// <summary>
        /// The tunnel endpoint label
        /// </summary>
        [JsonProperty(PropertyName = "tep_label", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"The tunnel endpoint label")]
        [System.ComponentModel.DataAnnotations.Required]
        public long TepLabel { get; set; }
        /// <summary>
        /// This is the identifier of the TEP segment. This segment is NOT the same as logical segment or logical switch.
        /// </summary>
        [JsonProperty(PropertyName = "segment_id")]
        [NSXTProperty(IsRequired: false, Description: @"This is the identifier of the TEP segment. This segment is NOT the same as logical segment or logical switch.")]
        public string? SegmentId { get; set; }
        /// <summary>
        /// The tunnel endpoint MAC address
        /// </summary>
        [JsonProperty(PropertyName = "tep_mac_address", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"The tunnel endpoint MAC address")]
        [System.ComponentModel.DataAnnotations.Required]
        public string TepMacAddress { get; set; }
        /// <summary>
        /// The tunnel endpoint IP address
        /// </summary>
        [JsonProperty(PropertyName = "tep_ip")]
        [NSXTProperty(IsRequired: false, Description: @"The tunnel endpoint IP address")]
        public string? TepIp { get; set; }
    }
}
