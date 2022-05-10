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
    /// Remote MAC addresses for logical switch.
    /// </summary>
    [NSXTProperty(Description: @"Remote MAC addresses for logical switch.")]
    public class NSXTL2VpnSessionRemoteMacForSegmentType 
    {
        /// <summary>
        /// Remote Mac addresses.
        /// </summary>
        [JsonProperty(PropertyName = "remote_mac_addresses")]
        public IList<string> RemoteMacAddresses { get; set; }
        /// <summary>
        /// Intent path of the segment.
        /// </summary>
        [JsonProperty(PropertyName = "segment_path", Required = Required.AllowNull)]
        public string SegmentPath { get; set; }
    }
}
