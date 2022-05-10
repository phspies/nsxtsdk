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
    public class NSXTBFDStatusCountType 
    {
        /// <summary>
        /// Number of tunnels in BFD admin down state
        /// </summary>
        [JsonProperty(PropertyName = "bfd_admin_down_count")]
        public int? BfdAdminDownCount { get; set; }
        /// <summary>
        /// Number of tunnels in BFD up state
        /// </summary>
        [JsonProperty(PropertyName = "bfd_up_count")]
        public int? BfdUpCount { get; set; }
        /// <summary>
        /// Number of tunnels in BFD down state
        /// </summary>
        [JsonProperty(PropertyName = "bfd_down_count")]
        public int? BfdDownCount { get; set; }
        /// <summary>
        /// Number of tunnels in BFD init state
        /// </summary>
        [JsonProperty(PropertyName = "bfd_init_count")]
        public int? BfdInitCount { get; set; }
    }
}
