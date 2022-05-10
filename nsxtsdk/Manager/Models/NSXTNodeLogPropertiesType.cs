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
    public class NSXTNodeLogPropertiesType : NSXTResourceType
    {
        /// <summary>
        /// Last modified time expressed in milliseconds since epoch
        /// </summary>
        [JsonProperty(PropertyName = "last_modified_time")]
        public long? LastModifiedTime { get; set; }
        /// <summary>
        /// Size of log file in bytes
        /// </summary>
        [JsonProperty(PropertyName = "log_size")]
        public long? LogSize { get; set; }
        /// <summary>
        /// Name of log file
        /// </summary>
        [JsonProperty(PropertyName = "log_name")]
        public string? LogName { get; set; }
    }
}
