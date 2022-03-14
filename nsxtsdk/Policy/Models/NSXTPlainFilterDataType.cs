// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using nsxtsdk.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.ComponentModel;
using NJsonSchema.Converters;

namespace nsxtsdk.PolicyModels
{
    /// <summary>
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTPlainFilterDataType : NSXTLiveTraceFilterDataType
    {
        /// <summary>
        /// Extended RCF rule for packet filter
        /// </summary>
        public string? ExtendFilter { get; set; }
        /// <summary>
        /// Basic RCF rule for packet filter
        /// </summary>
        public string? BasicFilter { get; set; }
    }
}
