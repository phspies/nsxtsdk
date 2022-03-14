// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using nsxtsdk.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.ComponentModel;
using NJsonSchema.Converters;

namespace nsxtsdk.ManagerModels
{
    /// <summary>
    /// SSH Service properties
    /// </summary>
    [NSXTProperty(Description: @"SSH Service properties")]
    public class NSXTSshServicePropertiesType 
    {
        /// <summary>
        /// Permit SSH Root login
        /// </summary>
        public bool? RootLogin { get; set; }
        /// <summary>
        /// Start service when system boots
        /// </summary>
        [JsonProperty(PropertyName = "start_on_boot", Required = Required.AllowNull)]
        public bool StartOnBoot { get; set; }
    }
}
