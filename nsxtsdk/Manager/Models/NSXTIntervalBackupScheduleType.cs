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
    public class NSXTIntervalBackupScheduleType : NSXTBackupScheduleType
    {
        /// <summary>
        /// Time interval in seconds between two consecutive automated backups
        /// </summary>
        [JsonProperty(PropertyName = "seconds_between_backups")]
        [NSXTProperty(IsRequired: false, Description: @"Time interval in seconds between two consecutive automated backups")]
        //[System.ComponentModel.DataAnnotations.MinLength(300)]
        //[System.ComponentModel.DataAnnotations.MaxLength(86400)]
        [NSXTDefaultProperty(Default: "")]
        public long? SecondsBetweenBackups { get; set; }
    }
}