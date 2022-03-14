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
    public class NSXTPolicyEdgeClusterInterSiteBgpSummaryType : NSXTListResultType
    {
        /// <summary>
        /// Edge cluster path whose status is being reported.
        /// </summary>
        public string? EdgeClusterPath { get; set; }
        /// <summary>
        /// Status of all edge nodes within cluster.
        /// </summary>
        public IList<NSXTPolicyEdgeNodeInterSiteBgpSummaryType> EdgeNodes { get; set; }
    }
}
