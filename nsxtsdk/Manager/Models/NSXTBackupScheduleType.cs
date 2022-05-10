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
    /// Abstract base type for Weekly or Interval Backup Schedule
    /// </summary>
    [NSXTProperty(Description: @"Abstract base type for Weekly or Interval Backup Schedule")]
    public class NSXTBackupScheduleType 
    {
        /// <summary>
        /// Schedule type
        /// </summary>
        [JsonProperty(PropertyName = "resource_type", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTBackupScheduleResourceTypeEnumType ResourceType { get; set; }
    }
}
