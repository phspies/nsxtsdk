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

namespace nsxtsdk.ManagerModels
{
    /// <summary>
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTLogicalSwitchMirrorSourceType : NSXTMirrorSourceType
    {
        public NSXTLogicalSwitchMirrorSourceType()
        {
        }
        /// <summary>
        /// Please note as logical port attached with vmk interface is unsupported
        /// as mirror source, traffic from those ports on source logical switch will
        /// not be mirrored.
        /// </summary>
        [JsonProperty(PropertyName = "switch_id", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"Please note as logical port attached with vmk interface is unsupportedas mirror source, traffic from those ports on source logical switch willnot be mirrored.")]
        [System.ComponentModel.DataAnnotations.Required]
        public string SwitchId { get; set; }
    }
}
