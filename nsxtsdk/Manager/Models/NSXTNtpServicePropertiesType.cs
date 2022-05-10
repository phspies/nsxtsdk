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
    /// NTP Service properties
    /// </summary>
    [NSXTProperty(Description: @"NTP Service properties")]
    public class NSXTNtpServicePropertiesType 
    {
        /// <summary>
        /// Start NTP service when system boots
        /// </summary>
        [JsonProperty(PropertyName = "start_on_boot")]
        public bool? StartOnBoot { get; set; }
        /// <summary>
        /// NTP servers
        /// </summary>
        [JsonProperty(PropertyName = "servers", Required = Required.AllowNull)]
        public IList<string> Servers { get; set; }
    }
}
