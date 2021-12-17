// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using nsxtsdk.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using NJsonSchema.Converters;
using System.ComponentModel;

namespace nsxtsdk.ManagerModels
{
    /// <summary>
    /// Service properties
    /// </summary>
    [NSXTProperty(Description: @"Service properties")]
    public class NSXTLoggingServicePropertiesType 
    {
        public NSXTLoggingServicePropertiesType()
        {
        }
        /// <summary>
        /// Package logging levels
        /// </summary>
        [JsonProperty(PropertyName = "package_logging_level")]
        [NSXTProperty(IsRequired: false, Description: @"Package logging levels")]
        public IList<NSXTPackageLoggingLevelsType> PackageLoggingLevel { get; set; }
        /// <summary>
        /// Service logging level
        /// </summary>
        [JsonProperty(PropertyName = "logging_level", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"Service logging level")]
        [System.ComponentModel.DataAnnotations.Required]
        public NSXTLoggingServicePropertiesLoggingLevelEnumType LoggingLevel { get; set; }
        /// <summary>
        /// Modified package logging levels
        /// </summary>
        [JsonProperty(PropertyName = "modified_package_logging_levels")]
        [NSXTProperty(IsRequired: false, Description: @"Modified package logging levels")]
        public string? ModifiedPackageLoggingLevels { get; set; }
    }
}
