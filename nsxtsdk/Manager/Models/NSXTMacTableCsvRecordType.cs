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
    public class NSXTMacTableCsvRecordType : NSXTCsvRecordType
    {
        /// <summary>
        /// The virtual tunnel endpoint MAC address
        /// </summary>
        [JsonProperty(PropertyName = "vtep_mac_address")]
        public string? VtepMacAddress { get; set; }
        /// <summary>
        /// RTEP group id is applicable when the logical switch is stretched
        /// across multiple sites. When rtep_group_id is set, mac_address
        /// represents remote mac_address.
        /// </summary>
        [JsonProperty(PropertyName = "rtep_group_id")]
        public long? RtepGroupId { get; set; }
        /// <summary>
        /// The virtual tunnel endpoint IP address
        /// </summary>
        [JsonProperty(PropertyName = "vtep_ip")]
        public string? VtepIp { get; set; }
        /// <summary>
        /// VTEP group id is applicable when the logical switch is stretched
        /// across multiple sites. When vtep_group_id is set, mac_address
        /// represents remote mac_address.
        /// </summary>
        [JsonProperty(PropertyName = "vtep_group_id")]
        public long? VtepGroupId { get; set; }
        /// <summary>
        /// The MAC address
        /// </summary>
        [JsonProperty(PropertyName = "mac_address", Required = Required.AllowNull)]
        public string MacAddress { get; set; }
    }
}
