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
    /// List of VMs on which a particular signature was detected with the count.
    /// </summary>
    [NSXTProperty(Description: @"List of VMs on which a particular signature was detected with the count.")]
    public class NSXTIdsVmStatsType 
    {
        /// <summary>
        /// Number of unique VMs on which a particular signature was detected.
        /// </summary>
        [JsonProperty(PropertyName = "count")]
        public long? Count { get; set; }
        /// <summary>
        /// List of VM names  on which intrusions of that particular signature type were detected.
        /// </summary>
        [JsonProperty(PropertyName = "vm_list")]
        public IList<string> VmList { get; set; }
    }
}
