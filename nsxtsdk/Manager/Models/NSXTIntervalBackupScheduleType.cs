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
    public class NSXTIntervalBackupScheduleType : NSXTBackupScheduleType
    {
        /// <summary>
        /// Time interval in seconds between two consecutive automated backups
        /// </summary>
        [JsonProperty(PropertyName = "seconds_between_backups")]
        public long? SecondsBetweenBackups { get; set; }
    }
}
