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
    /// File system properties
    /// </summary>
    [NSXTProperty(Description: @"File system properties")]
    public class NSXTNodeFileSystemPropertiesType 
    {
        /// <summary>
        /// File system mount
        /// </summary>
        [JsonProperty(PropertyName = "mount")]
        public string? Mount { get; set; }
        /// <summary>
        /// File system size in kilobytes
        /// </summary>
        [JsonProperty(PropertyName = "total")]
        public long? Total { get; set; }
        /// <summary>
        /// File system type
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string? Type { get; set; }
        /// <summary>
        /// File system id
        /// </summary>
        [JsonProperty(PropertyName = "file_system")]
        public string? FileSystem { get; set; }
        /// <summary>
        /// Amount of file system used in kilobytes
        /// </summary>
        [JsonProperty(PropertyName = "used")]
        public long? Used { get; set; }
    }
}
