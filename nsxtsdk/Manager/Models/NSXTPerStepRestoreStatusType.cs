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
    /// Restore step status
    /// </summary>
    [NSXTProperty(Description: @"Restore step status")]
    public class NSXTPerStepRestoreStatusType 
    {
        /// <summary>
        /// A description of the restore status
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string? Description { get; set; }
        /// <summary>
        /// Per step restore status value
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTPerStepRestoreStatusValueEnumType? Value { get; set; }
    }
}
