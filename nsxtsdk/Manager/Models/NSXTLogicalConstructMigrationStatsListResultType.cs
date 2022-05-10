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
    public class NSXTLogicalConstructMigrationStatsListResultType : NSXTListResultType
    {
        /// <summary>
        /// Paged collection of migration stats for logical constructs
        /// </summary>
        [JsonProperty(PropertyName = "results")]
        public IList<NSXTLogicalConstructMigrationStatsType> Results { get; set; }
    }
}
