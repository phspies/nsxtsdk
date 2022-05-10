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
    /// Overall restore process status
    /// </summary>
    [NSXTProperty(Description: @"Overall restore process status")]
    public class NSXTGlobalRestoreStatusType 
    {
        /// <summary>
        /// A description of the restore status
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string? Description { get; set; }
        /// <summary>
        /// Global rolled-up restore status value
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTGlobalRestoreStatusValueEnumType? Value { get; set; }
    }
}
