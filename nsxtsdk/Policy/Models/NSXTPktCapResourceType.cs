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
    public class NSXTPktCapResourceType : NSXTBasePktCapResourceType
    {
        /// <summary>
        /// Packet capture file download URL
        /// </summary>
        [JsonProperty(PropertyName = "pktcap_file_download_url")]
        [NSXTProperty(IsRequired: false, Description: @"Packet capture file download URL")]
        public string? PktcapFileDownloadUrl { get; set; }
        /// <summary>
        /// The ID of logical port where packet capture action is performed
        /// </summary>
        [JsonProperty(PropertyName = "port_id")]
        [NSXTProperty(IsRequired: false, Description: @"The ID of logical port where packet capture action is performed")]
        public string? PortId { get; set; }
    }
}
