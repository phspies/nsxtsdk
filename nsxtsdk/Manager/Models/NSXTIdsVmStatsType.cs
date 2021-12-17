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

namespace nsxtsdk.ManagerModels
{
    /// <summary>
    /// List of VMs on which a particular signature was detected with the count.
    /// </summary>
    [NSXTProperty(Description: @"List of VMs on which a particular signature was detected with the count.")]
    public class NSXTIdsVmStatsType 
    {
        public NSXTIdsVmStatsType()
        {
        }
        /// <summary>
        /// Number of unique VMs on which a particular signature was detected.
        /// </summary>
        [JsonProperty(PropertyName = "count")]
        [NSXTProperty(IsRequired: false, Description: @"Number of unique VMs on which a particular signature was detected.")]
        public long? Count { get; set; }
        /// <summary>
        /// List of VM names  on which intrusions of that particular signature type were detected.
        /// </summary>
        [JsonProperty(PropertyName = "vm_list")]
        [NSXTProperty(IsRequired: false, Description: @"List of VM names  on which intrusions of that particular signature type were detected.")]
        public IList<string> VmList { get; set; }
    }
}
