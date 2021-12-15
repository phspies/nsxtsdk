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
    /// File system properties
    /// </summary>
    [NSXTProperty(Description: @"File system properties")]
    public class NSXTNodeFileSystemPropertiesType 
    {
        /// <summary>
        /// File system mount
        /// </summary>
        [JsonProperty(PropertyName = "mount")]
        [NSXTProperty(IsRequired: false, Description: @"File system mount")]
        public string? Mount { get; set; }
        /// <summary>
        /// File system size in kilobytes
        /// </summary>
        [JsonProperty(PropertyName = "total")]
        [NSXTProperty(IsRequired: false, Description: @"File system size in kilobytes")]
        public long? Total { get; set; }
        /// <summary>
        /// File system type
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        [NSXTProperty(IsRequired: false, Description: @"File system type")]
        public string? Type { get; set; }
        /// <summary>
        /// File system id
        /// </summary>
        [JsonProperty(PropertyName = "file_system")]
        [NSXTProperty(IsRequired: false, Description: @"File system id")]
        public string? FileSystem { get; set; }
        /// <summary>
        /// Amount of file system used in kilobytes
        /// </summary>
        [JsonProperty(PropertyName = "used")]
        [NSXTProperty(IsRequired: false, Description: @"Amount of file system used in kilobytes")]
        public long? Used { get; set; }
    }
}
