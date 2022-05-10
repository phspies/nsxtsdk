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
    /// Contains manager and policy resource id.
    /// </summary>
    [NSXTProperty(Description: @"Contains manager and policy resource id.")]
    public class NSXTMpMigrationDataType 
    {
        /// <summary>
        /// Default value is false. This value will indicate if there is error,
        /// skip the failed objects and proceed with next set of objects for MP to Policy promotion.
        /// </summary>
        [JsonProperty(PropertyName = "skip_failed_resources")]
        public bool? SkipFailedResources { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "setup_details")]
        public NSXTSetupDetailsType SetupDetails { get; set; }
        /// <summary>
        /// migration data ( resource type and Ids ).
        /// </summary>
        [JsonProperty(PropertyName = "migration_data")]
        public IList<NSXTMPResourceType> MigrationData { get; set; }
        /// <summary>
        /// Mode of MP2Policy migration
        /// </summary>
        [JsonProperty(PropertyName = "mode")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTMpMigrationDataModeEnumType? Mode { get; set; }
    }
}
