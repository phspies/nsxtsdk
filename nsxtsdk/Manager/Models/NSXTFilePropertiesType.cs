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
    public class NSXTFilePropertiesType : NSXTResourceType
    {
        /// <summary>
        /// File creation time in epoch milliseconds
        /// </summary>
        [JsonProperty(PropertyName = "created_epoch_ms", Required = Required.AllowNull)]
        public long CreatedEpochMs { get; set; }
        /// <summary>
        /// File modification time in epoch milliseconds
        /// </summary>
        [JsonProperty(PropertyName = "modified_epoch_ms", Required = Required.AllowNull)]
        public long ModifiedEpochMs { get; set; }
        /// <summary>
        /// File name
        /// </summary>
        [JsonProperty(PropertyName = "name", Required = Required.AllowNull)]
        public string Name { get; set; }
        /// <summary>
        /// Size of the file in bytes
        /// </summary>
        [JsonProperty(PropertyName = "size", Required = Required.AllowNull)]
        public long Size { get; set; }
    }
}
