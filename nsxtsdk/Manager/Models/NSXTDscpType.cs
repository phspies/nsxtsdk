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
    /// Dscp value is ignored in case of 'TRUSTED' DscpMode.
    /// </summary>
    [NSXTProperty(Description: @"Dscp value is ignored in case of &apos;TRUSTED&apos; DscpMode.")]
    public class NSXTDscpType 
    {
        /// <summary>
        /// Internal Forwarding Priority
        /// </summary>
        [JsonProperty(PropertyName = "priority")]
        public int? Priority { get; set; }
        /// <summary>
        /// Trust settings
        /// </summary>
        [JsonProperty(PropertyName = "mode")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTDscpModeEnumType? Mode { get; set; }
    }
}
