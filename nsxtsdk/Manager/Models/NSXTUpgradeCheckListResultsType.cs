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
    public class NSXTUpgradeCheckListResultsType 
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "failed_checks")]
        public NSXTUpgradeCheckListResultType FailedChecks { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "checks_with_warnings")]
        public NSXTUpgradeCheckListResultType ChecksWithWarnings { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "successful_checks")]
        public NSXTUpgradeCheckListResultType SuccessfulChecks { get; set; }
    }
}
