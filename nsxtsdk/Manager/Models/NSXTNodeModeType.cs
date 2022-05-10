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
    /// Possible values of a mode in a "/config/nsx_appliance_mode" file
    /// </summary>
    [NSXTProperty(Description: @"Possible values of a mode in a &quot;/config/nsx_appliance_mode&quot; file")]
    public class NSXTNodeModeType 
    {
        /// <summary>
        /// Possible enum values in a "/config/nsx_appliance_mode" file
        /// </summary>
        [JsonProperty(PropertyName = "mode_id", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTNodeModeModeIdEnumType ModeId { get; set; }
    }
}
