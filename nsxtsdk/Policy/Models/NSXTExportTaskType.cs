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
    public class NSXTExportTaskType : NSXTPolicyTaskType
    {
        /// <summary>
        /// Policy path of a draft if this is an export task to export draft
        /// configuration.
        /// </summary>
        [JsonProperty(PropertyName = "draft_path")]
        public string? DraftPath { get; set; }
        /// <summary>
        /// Name of the exported file generated after completion of export task.
        /// </summary>
        [JsonProperty(PropertyName = "exported_file")]
        public string? ExportedFile { get; set; }
    }
}
