using nsxtsdk.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.ComponentModel;
using NJsonSchema.Converters;
using Newtonsoft.Json.Converters;

namespace nsxtsdk.PolicyModels
{
    /// <summary>
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTTlsCsrWithDaysValidType : NSXTTlsCsrType
    {
        /// <summary>
        /// Number of days the certificate will be valid, default 825 days
        /// </summary>
        [JsonProperty(PropertyName = "days_valid")]
        public long? DaysValid { get; set; }
    }
}
