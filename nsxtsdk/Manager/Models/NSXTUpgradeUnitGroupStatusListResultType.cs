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
    public class NSXTUpgradeUnitGroupStatusListResultType : NSXTListResultType
    {
        /// <summary>
        /// Paged collection of upgrade status for upgrade unit groups
        /// </summary>
        [JsonProperty(PropertyName = "results")]
        public IList<NSXTUpgradeUnitGroupStatusType> Results { get; set; }
    }
}
