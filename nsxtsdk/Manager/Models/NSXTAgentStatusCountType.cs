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
    public class NSXTAgentStatusCountType 
    {
        /// <summary>
        /// Roll-up agent status
        /// </summary>
        public NSXTAgentStatusCountStatusEnumType? Status { get; set; }
        /// <summary>
        /// Down count
        /// </summary>
        public int? DownCount { get; set; }
        /// <summary>
        /// List of agent statuses belonging to the transport node
        /// </summary>
        public IList<NSXTAgentStatusType> Agents { get; set; }
        /// <summary>
        /// Up count
        /// </summary>
        public int? UpCount { get; set; }
    }
}
