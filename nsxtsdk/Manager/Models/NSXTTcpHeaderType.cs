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
    public class NSXTTcpHeaderType 
    {
        /// <summary>
        /// TCP flags (9bits)
        /// </summary>
        public long? TcpFlags { get; set; }
        /// <summary>
        /// Source port of tcp header
        /// </summary>
        public long? SrcPort { get; set; }
        /// <summary>
        /// Destination port of tcp header
        /// </summary>
        public long? DstPort { get; set; }
    }
}
