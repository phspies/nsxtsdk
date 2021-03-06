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
    /// Advanced load balancer ClientLogConfiguration object
    /// </summary>
    [NSXTProperty(Description: @"Advanced load balancer ClientLogConfiguration object")]
    public class NSXTALBClientLogConfigurationType 
    {
        /// <summary>
        /// Enable significant log collection.
        /// By default, this flag is enabled, which means that Avi SEs
        /// collect significant logs and forward them to Controller for
        /// further processing.
        /// For example, these logs correspond to error conditions such
        /// as when the response code for a request is 500.
        /// Users can deactivate this flag to turn off default
        /// significant log collection.
        /// Allowed in Basic(Allowed values- false) edition,
        /// Essentials(Allowed values- false) edition, Enterprise
        /// edition.
        /// Special default for Basic edition is false, Essentials
        /// edition is false, Enterprise is True.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as false.
        /// </summary>
        [JsonProperty(PropertyName = "enable_significant_log_collection")]
        public bool? EnableSignificantLogCollection { get; set; }
        /// <summary>
        /// Significant logs are processed by the Logs Analytics system
        /// according to this setting.
        /// Enum options - LOGS_PROCESSING_NONE,
        /// LOGS_PROCESSING_SYNC_AND_INDEX_ON_DEMAND,
        /// LOGS_PROCESSING_AUTO_SYNC_AND_INDEX,
        /// LOGS_PROCESSING_AUTO_SYNC_BUT_INDEX_ON_DEMAND.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as
        /// LOGS_PROCESSING_SYNC_AND_INDEX_ON_DEMAND.
        /// </summary>
        [JsonProperty(PropertyName = "significant_log_processing")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTAlbclientLogConfigurationSignificantLogProcessingEnumType? SignificantLogProcessing { get; set; }
        /// <summary>
        /// Logs that are neither significant nor filtered, are
        /// processed by the Logs Analytics system according to this
        /// setting.
        /// Enum options - LOGS_PROCESSING_NONE,
        /// LOGS_PROCESSING_SYNC_AND_INDEX_ON_DEMAND,
        /// LOGS_PROCESSING_AUTO_SYNC_AND_INDEX,
        /// LOGS_PROCESSING_AUTO_SYNC_BUT_INDEX_ON_DEMAND.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as
        /// LOGS_PROCESSING_SYNC_AND_INDEX_ON_DEMAND.
        /// </summary>
        [JsonProperty(PropertyName = "non_significant_log_processing")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTAlbclientLogConfigurationNonSignificantLogProcessingEnumType? NonSignificantLogProcessing { get; set; }
        /// <summary>
        /// Filtered logs are logs that match any client log filters or
        /// rules with logging enabled.
        /// Such logs are processed by the Logs Analytics system
        /// according to this setting.
        /// Enum options - LOGS_PROCESSING_NONE,
        /// LOGS_PROCESSING_SYNC_AND_INDEX_ON_DEMAND,
        /// LOGS_PROCESSING_AUTO_SYNC_AND_INDEX,
        /// LOGS_PROCESSING_AUTO_SYNC_BUT_INDEX_ON_DEMAND.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as
        /// LOGS_PROCESSING_SYNC_AND_INDEX_ON_DEMAND.
        /// </summary>
        [JsonProperty(PropertyName = "filtered_log_processing")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTAlbclientLogConfigurationFilteredLogProcessingEnumType? FilteredLogProcessing { get; set; }
    }
}
