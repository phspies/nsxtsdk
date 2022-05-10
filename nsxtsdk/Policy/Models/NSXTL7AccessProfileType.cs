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
    public class NSXTL7AccessProfileType : NSXTPolicyConfigResourceType
    {
        /// <summary>
        /// Flag to enable packet logging. Default is disabled.
        /// </summary>
        [JsonProperty(PropertyName = "default_action_logged")]
        public bool? DefaultActionLogged { get; set; }
        /// <summary>
        /// The action to be applied to all the services.
        /// </summary>
        [JsonProperty(PropertyName = "default_action", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTL7AccessProfileDefaultActionEnumType DefaultAction { get; set; }
        /// <summary>
        /// The count of entries in the L7 profile.
        /// </summary>
        [JsonProperty(PropertyName = "entry_count")]
        public int? EntryCount { get; set; }
        /// <summary>
        /// Property containing L7 access entries for Policy L7 Access Profile.
        /// </summary>
        [JsonProperty(PropertyName = "l7_access_entries")]
        public IList<NSXTL7AccessEntryType> L7AccessEntries { get; set; }
    }
}
