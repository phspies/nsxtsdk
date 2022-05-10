using nsxtsdk.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.ComponentModel;
using NJsonSchema.Converters;
using Newtonsoft.Json.Converters;

namespace nsxtsdk.ManagerModels
{
    /// <summary>
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTSupportBundleResultType 
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "request_properties")]
        public NSXTSupportBundleRequestType RequestProperties { get; set; }
        /// <summary>
        /// Nodes where bundles were not generated or not copied to remote server
        /// </summary>
        [JsonProperty(PropertyName = "failed_nodes")]
        public IList<NSXTFailedNodeSupportBundleResultType> FailedNodes { get; set; }
        /// <summary>
        /// Nodes whose bundles were successfully copied to remote file server
        /// </summary>
        [JsonProperty(PropertyName = "success_nodes")]
        public IList<NSXTSuccessNodeSupportBundleResultType> SuccessNodes { get; set; }
        /// <summary>
        /// Nodes where bundle generation is pending or in progress
        /// </summary>
        [JsonProperty(PropertyName = "remaining_nodes")]
        public IList<NSXTRemainingSupportBundleNodeType> RemainingNodes { get; set; }
    }
}
