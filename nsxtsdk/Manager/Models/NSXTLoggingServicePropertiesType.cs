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
    /// Service properties
    /// </summary>
    [NSXTProperty(Description: @"Service properties")]
    public class NSXTLoggingServicePropertiesType 
    {
        /// <summary>
        /// Package logging levels
        /// </summary>
        [JsonProperty(PropertyName = "package_logging_level")]
        public IList<NSXTPackageLoggingLevelsType> PackageLoggingLevel { get; set; }
        /// <summary>
        /// Service logging level
        /// </summary>
        [JsonProperty(PropertyName = "logging_level", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTLoggingServicePropertiesLoggingLevelEnumType LoggingLevel { get; set; }
        /// <summary>
        /// Modified package logging levels
        /// </summary>
        [JsonProperty(PropertyName = "modified_package_logging_levels")]
        public string? ModifiedPackageLoggingLevels { get; set; }
    }
}
