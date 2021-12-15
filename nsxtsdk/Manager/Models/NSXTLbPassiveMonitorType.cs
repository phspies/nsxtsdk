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
    public class NSXTLbPassiveMonitorType : NSXTLbMonitorType
    {
        /// <summary>
        /// When the consecutive failures reach this value, then the member is
        /// considered temporarily unavailable for a configurable period
        /// </summary>
        [JsonProperty(PropertyName = "max_fails")]
        [NSXTProperty(IsRequired: false, Description: @"When the consecutive failures reach this value, then the member isconsidered temporarily unavailable for a configurable period")]
        //[System.ComponentModel.DataAnnotations.MinLength(1)]
        //[System.ComponentModel.DataAnnotations.MaxLength(2147483647)]
        [NSXTDefaultProperty(Default: "")]
        public long? MaxFails { get; set; }
        /// <summary>
        /// After this timeout period, the member is tried again for a new
        /// connection to see if it is available.
        /// </summary>
        [JsonProperty(PropertyName = "timeout")]
        [NSXTProperty(IsRequired: false, Description: @"After this timeout period, the member is tried again for a newconnection to see if it is available.")]
        //[System.ComponentModel.DataAnnotations.MinLength(1)]
        //[System.ComponentModel.DataAnnotations.MaxLength(2147483647)]
        [NSXTDefaultProperty(Default: "")]
        public long? Timeout { get; set; }
    }
}
