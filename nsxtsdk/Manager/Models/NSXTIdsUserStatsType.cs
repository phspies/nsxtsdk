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
    /// List of Users logged into VMs where intrusions of a given signature
        /// were detected.
    /// </summary>
    [NSXTProperty(Description: @"List of Users logged into VMs where intrusions of a given signaturewere detected.")]
    public class NSXTIdsUserStatsType 
    {
        /// <summary>
        /// Number of unique users logged into VMs on which a particular signature was detected.
        /// </summary>
        [JsonProperty(PropertyName = "count")]
        [NSXTProperty(IsRequired: false, Description: @"Number of unique users logged into VMs on which a particular signature was detected.")]
        public long? Count { get; set; }
        /// <summary>
        /// List of users logged into VMs on which a particular signature was detected.
        /// </summary>
        [JsonProperty(PropertyName = "user_list")]
        [NSXTProperty(IsRequired: false, Description: @"List of users logged into VMs on which a particular signature was detected.")]
        public IList<string> UserList { get; set; }
    }
}
