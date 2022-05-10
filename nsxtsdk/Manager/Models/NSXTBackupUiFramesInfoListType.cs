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
    public class NSXTBackupUiFramesInfoListType 
    {
        /// <summary>
        /// List of backup frames(and metadata) to be displayed in UI
        /// </summary>
        [JsonProperty(PropertyName = "backup_frames_list")]
        public IList<NSXTBackupUiFramesInfoType> BackupFramesList { get; set; }
    }
}
