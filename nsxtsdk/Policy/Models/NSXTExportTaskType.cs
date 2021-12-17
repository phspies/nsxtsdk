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

namespace nsxtsdk.PolicyModels
{
    /// <summary>
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTExportTaskType : NSXTPolicyTaskType
    {
        public NSXTExportTaskType()
        {
        }
        /// <summary>
        /// Policy path of a draft if this is an export task to export draft
        /// configuration.
        /// </summary>
        [JsonProperty(PropertyName = "draft_path")]
        [NSXTProperty(IsRequired: false, Description: @"Policy path of a draft if this is an export task to export draftconfiguration.")]
        public string? DraftPath { get; set; }
        /// <summary>
        /// Name of the exported file generated after completion of export task.
        /// </summary>
        [JsonProperty(PropertyName = "exported_file")]
        [NSXTProperty(IsRequired: false, Description: @"Name of the exported file generated after completion of export task.")]
        public string? ExportedFile { get; set; }
    }
}
