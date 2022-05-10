using nsxtsdk.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.ComponentModel;
using NJsonSchema.Converters;
using Newtonsoft.Json.Converters;

namespace nsxtsdk.PolicyModels
{
    /// <summary>
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTImportTaskType : NSXTPolicyTaskType
    {
        /// <summary>
        /// Policy path of a draft in which the imported configuration gets stored
        /// after completion of import task.
        /// </summary>
        [JsonProperty(PropertyName = "draft_path")]
        public string? DraftPath { get; set; }
    }
}
