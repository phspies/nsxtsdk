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

namespace nsxtsdk.ManagerModels
{
    /// <summary>
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTSIAggregatedDataCounterType 
    {
        /// <summary>
        /// 
        /// </summary>
        public NSXTSIDataCounterType TxBytes { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public NSXTSIDataCounterType RxPackets { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public NSXTSIDataCounterType TxPackets { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public NSXTSIDataCounterType RxBytes { get; set; }
    }
}
