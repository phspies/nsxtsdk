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
    public class NSXTPlainFilterDataType : NSXTLiveTraceFilterDataType
    {
        public NSXTPlainFilterDataType()
        {
        }
        /// <summary>
        /// Extended RCF rule for packet filter
        /// </summary>
        [JsonProperty(PropertyName = "extend_filter")]
        [NSXTProperty(IsRequired: false, Description: @"Extended RCF rule for packet filter")]
        public string? ExtendFilter { get; set; }
        /// <summary>
        /// Basic RCF rule for packet filter
        /// </summary>
        [JsonProperty(PropertyName = "basic_filter")]
        [NSXTProperty(IsRequired: false, Description: @"Basic RCF rule for packet filter")]
        public string? BasicFilter { get; set; }
    }
}
