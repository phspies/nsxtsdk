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
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTAntreaHeartbeatConfigType : NSXTPolicyConfigResourceType
    {
        public NSXTAntreaHeartbeatConfigType()
        {
            ReportInterval = test
        }
        /// <summary>
        /// If exceeding 3*report_interval, there is still no heartbeat, cluster status will be UNKNOWN.
        /// </summary>
        [JsonProperty(PropertyName = "report_interval", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"If exceeding 3*report_interval, there is still no heartbeat, cluster status will be UNKNOWN.")]
        //[System.ComponentModel.DataAnnotations.MinLength(60)]
        //[System.ComponentModel.DataAnnotations.MaxLength(600)]
        [System.ComponentModel.DataAnnotations.Required]
        public int ReportInterval { get; set; }
    }
}