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
    public class NSXTServiceType : NSXTPolicyConfigResourceType
    {
        /// <summary>
        /// The flag, if true, indicates that service is created in the system by default.
        /// Such default services can't be modified/deleted.
        /// </summary>
        [JsonProperty(PropertyName = "is_default")]
        public bool? IsDefault { get; set; }
        /// <summary>
        /// Type of service, EITHER or NON_ETHER
        /// </summary>
        [JsonProperty(PropertyName = "service_type")]
        public string? ServiceType { get; set; }
        /// <summary>
        /// Service type
        /// </summary>
        [JsonProperty(PropertyName = "service_entries")]
        public IList<NSXTServiceEntryType> ServiceEntries { get; set; }
    }
}
