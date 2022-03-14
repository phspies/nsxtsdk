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
    public class NSXTPolicyNatRuleStatisticsPerTransportNodeType : NSXTPolicyNATRuleCountersType
    {
        /// <summary>
        /// Timestamp when the data was last updated.
        /// </summary>
        public long? LastUpdateTimestamp { get; set; }
        /// <summary>
        /// Policy path of the Edge Node.
        /// </summary>
        public string? TransportNodePath { get; set; }
    }
}
