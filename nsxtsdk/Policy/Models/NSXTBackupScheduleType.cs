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
    /// Abstract base type for Weekly or Interval Backup Schedule
    /// </summary>
    [NSXTProperty(Description: @"Abstract base type for Weekly or Interval Backup Schedule")]
    public class NSXTBackupScheduleType 
    {
        /// <summary>
        /// Schedule type
        /// </summary>
        [JsonProperty(PropertyName = "resource_type", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"Schedule type")]
        [System.ComponentModel.DataAnnotations.Required]
        public NSXTBackupScheduleResourceTypeEnumType ResourceType { get; set; }
    }
}