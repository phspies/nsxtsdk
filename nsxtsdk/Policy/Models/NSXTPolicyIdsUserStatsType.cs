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
    /// List of Users logged into VMs where intrusions of a given signature
        /// were detected.
    /// </summary>
    [NSXTProperty(Description: @"List of Users logged into VMs where intrusions of a given signaturewere detected.")]
    public class NSXTPolicyIdsUserStatsType 
    {
        /// <summary>
        /// Number of unique users logged into VMs on which a particular signature was detected.
        /// </summary>
        [JsonProperty(PropertyName = "count")]
        public long? Count { get; set; }
        /// <summary>
        /// List of users logged into VMs on which a particular signature was detected.
        /// </summary>
        [JsonProperty(PropertyName = "user_list")]
        public IList<string> UserList { get; set; }
    }
}
