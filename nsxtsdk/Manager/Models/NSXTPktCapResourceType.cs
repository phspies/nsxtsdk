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
    public class NSXTPktCapResourceType : NSXTBasePktCapResourceType
    {
        /// <summary>
        /// Packet capture file download URL
        /// </summary>
        [JsonProperty(PropertyName = "pktcap_file_download_url")]
        public string? PktcapFileDownloadUrl { get; set; }
        /// <summary>
        /// The ID of logical port where packet capture action is performed
        /// </summary>
        [JsonProperty(PropertyName = "port_id")]
        public string? PortId { get; set; }
    }
}
