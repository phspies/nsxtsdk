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
    public class NSXTPackageLoggingLevelsType 
    {
        /// <summary>
        /// Logging levels per package
        /// </summary>
        [JsonProperty(PropertyName = "logging_level")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTPackageLoggingLevelsLoggingLevelEnumType? LoggingLevel { get; set; }
        /// <summary>
        /// Package name
        /// </summary>
        [JsonProperty(PropertyName = "package_name")]
        public string? PackageName { get; set; }
    }
}
