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
    /// Remote MAC addresses for logical switch.
    /// </summary>
    [NSXTProperty(Description: @"Remote MAC addresses for logical switch.")]
    public class NSXTL2VPNSessionRemoteMacsForLSType 
    {
        /// <summary>
        /// Mac addresses.
        /// </summary>
        [JsonProperty(PropertyName = "remote_mac_addresses")]
        public IList<string> RemoteMacAddresses { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "logical_switch")]
        public NSXTResourceReferenceType LogicalSwitch { get; set; }
        /// <summary>
        /// Contains policy specific information like policy path.
        /// </summary>
        [JsonProperty(PropertyName = "tags")]
        public IList<NSXTTagType> Tags { get; set; }
    }
}
