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
    /// Rule statistics for a specfic enforcement point.
    /// </summary>
    [NSXTProperty(Description: @"Rule statistics for a specfic enforcement point.")]
    public class NSXTRuleStatisticsForEnforcementPointType 
    {
        /// <summary>
        /// Rule statistics for a single enforcement point
        /// </summary>
        public string? EnforcementPoint { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public NSXTRuleStatisticsType Statistics { get; set; }
        /// <summary>
        /// Rule statistics for a single container cluster
        /// </summary>
        public string? ContainerClusterPath { get; set; }
    }
}
