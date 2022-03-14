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
    public class NSXTSegmentL2ForwarderSiteSpanInfoType 
    {
        /// <summary>
        /// Timestamp when the L2 forwarder remote mac addresses was last updated.
        /// </summary>
        public long? LastUpdateTimestamp { get; set; }
        /// <summary>
        /// Inter-site forwarder status per node.
        /// </summary>
        public IList<NSXTL2ForwarderStatusPerNodeType> InterSiteForwarderStatus { get; set; }
        /// <summary>
        /// L2 forwarder remote mac addresses per site for logical switch.
        /// </summary>
        public IList<NSXTL2ForwarderRemoteMacsPerSiteType> RemoteMacsPerSite { get; set; }
        /// <summary>
        /// Policy path of a segment.
        /// </summary>
        public string? SegmentPath { get; set; }
    }
}
