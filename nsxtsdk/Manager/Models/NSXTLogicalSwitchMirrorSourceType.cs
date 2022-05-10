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
    public class NSXTLogicalSwitchMirrorSourceType : NSXTMirrorSourceType
    {
        /// <summary>
        /// Please note as logical port attached with vmk interface is unsupported
        /// as mirror source, traffic from those ports on source logical switch will
        /// not be mirrored.
        /// </summary>
        [JsonProperty(PropertyName = "switch_id", Required = Required.AllowNull)]
        public string SwitchId { get; set; }
    }
}
