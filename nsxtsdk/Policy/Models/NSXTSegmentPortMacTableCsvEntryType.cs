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
    public class NSXTSegmentPortMacTableCsvEntryType : NSXTCsvRecordType
    {
        /// <summary>
        /// The type of the MAC address
        /// </summary>
        [JsonProperty(PropertyName = "mac_type", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTSegmentPortMacTableCsvEntryMacTypeEnumType MacType { get; set; }
        /// <summary>
        /// The MAC address
        /// </summary>
        [JsonProperty(PropertyName = "mac_address", Required = Required.AllowNull)]
        public string MacAddress { get; set; }
    }
}
