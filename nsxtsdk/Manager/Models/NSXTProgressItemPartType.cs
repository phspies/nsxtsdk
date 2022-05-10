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
    public class NSXTProgressItemPartType 
    {
        /// <summary>
        /// Status of this process
        /// </summary>
        [JsonProperty(PropertyName = "status", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTProgressItemPartStatusEnumType Status { get; set; }
        /// <summary>
        /// 0 - 100 of the task being completed
        /// </summary>
        [JsonProperty(PropertyName = "percentage", Required = Required.AllowNull)]
        public long Percentage { get; set; }
        /// <summary>
        /// Error message, if ran into error
        /// </summary>
        [JsonProperty(PropertyName = "error")]
        public string? Error { get; set; }
        /// <summary>
        /// Description of the process
        /// </summary>
        [JsonProperty(PropertyName = "description", Required = Required.AllowNull)]
        public string Description { get; set; }
        /// <summary>
        /// Name of the process
        /// </summary>
        [JsonProperty(PropertyName = "name", Required = Required.AllowNull)]
        public string Name { get; set; }
    }
}
