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
    public class NSXTPolicyComplianceStatusType 
    {
        /// <summary>
        /// Timestamp of last update
        /// </summary>
        [JsonProperty(PropertyName = "last_updated_time")]
        public long? LastUpdatedTime { get; set; }
        /// <summary>
        /// List of non compliant configuration and impacted services
        /// </summary>
        [JsonProperty(PropertyName = "non_compliant_configs")]
        public IList<NSXTPolicyNonCompliantConfigType> NonCompliantConfigs { get; set; }
    }
}
