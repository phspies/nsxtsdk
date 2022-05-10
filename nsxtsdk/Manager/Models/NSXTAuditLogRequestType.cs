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
    public class NSXTAuditLogRequestType 
    {
        /// <summary>
        /// Audit logs should meet the filter condition
        /// </summary>
        [JsonProperty(PropertyName = "log_filter")]
        public string? LogFilter { get; set; }
        /// <summary>
        /// Include logs with timstamps not past the age limit in days
        /// </summary>
        [JsonProperty(PropertyName = "log_age_limit")]
        public long? LogAgeLimit { get; set; }
        /// <summary>
        /// Type of log filter
        /// </summary>
        [JsonProperty(PropertyName = "log_filter_type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTAuditLogRequestLogFilterTypeEnumType? LogFilterType { get; set; }
    }
}
