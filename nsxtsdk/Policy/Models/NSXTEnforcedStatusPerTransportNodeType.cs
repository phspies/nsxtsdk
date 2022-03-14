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
    /// Detailed Realized Status Per Transport Node.
    /// </summary>
    [NSXTProperty(Description: @"Detailed Realized Status Per Transport Node.")]
    public class NSXTEnforcedStatusPerTransportNodeType 
    {
        /// <summary>
        /// 
        /// </summary>
        public NSXTEnforcedStatusNsxTType EnforcedStatus { get; set; }
        /// <summary>
        /// Policy Path referencing the transport node.
        /// </summary>
        public string? Path { get; set; }
        /// <summary>
        /// UUID identifying uniquely the Transport Node.
        /// </summary>
        public string? NsxId { get; set; }
        /// <summary>
        /// Display name of the transport node.
        /// </summary>
        public string? DisplayName { get; set; }
    }
}
