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
    /// Node system time in UTC
    /// </summary>
    [NSXTProperty(Description: @"Node system time in UTC")]
    public class NSXTNodeTimeType 
    {
        /// <summary>
        /// Datetime string in UTC
        /// </summary>
        [JsonProperty(PropertyName = "system_datetime", Required = Required.AllowNull)]
        public string SystemDatetime { get; set; }
    }
}
