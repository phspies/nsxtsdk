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
    public class NSXTFirewallSectionsSummaryListType 
    {
        /// <summary>
        /// Timestamp of the last computation, in epoch milliseconds.
        /// </summary>
        public long? LastComputeTime { get; set; }
        /// <summary>
        /// List of firewall sections summary.
        /// </summary>
        public IList<NSXTFirewallSectionsSummaryType> SectionsSummary { get; set; }
    }
}
