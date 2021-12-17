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
    /// Time interval on which firewall schedule will be applicable
    /// </summary>
    [NSXTProperty(Description: @"Time interval on which firewall schedule will be applicable")]
    public class NSXTPolicyTimeIntervalValueType 
    {
        public NSXTPolicyTimeIntervalValueType()
        {
        }
        /// <summary>
        /// Time in 24 hour and minutes in multiple of 30. Example, 9:00.
        /// </summary>
        [JsonProperty(PropertyName = "start_interval", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"Time in 24 hour and minutes in multiple of 30. Example, 9:00.")]
        [System.ComponentModel.DataAnnotations.Required]
        public string StartInterval { get; set; }
        /// <summary>
        /// Time in 24 hour and minutes in multiple of 30. Example, 17:30.
        /// </summary>
        [JsonProperty(PropertyName = "end_interval", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"Time in 24 hour and minutes in multiple of 30. Example, 17:30.")]
        [System.ComponentModel.DataAnnotations.Required]
        public string EndInterval { get; set; }
    }
}
