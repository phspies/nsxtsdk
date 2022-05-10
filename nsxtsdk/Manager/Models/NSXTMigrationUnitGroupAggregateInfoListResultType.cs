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
    public class NSXTMigrationUnitGroupAggregateInfoListResultType : NSXTListResultType
    {
        /// <summary>
        /// Paged collection of migration status for migration unit groups
        /// </summary>
        [JsonProperty(PropertyName = "results")]
        public IList<NSXTMigrationUnitGroupAggregateInfoType> Results { get; set; }
    }
}
