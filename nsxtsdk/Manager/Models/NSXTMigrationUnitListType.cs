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
    public class NSXTMigrationUnitListType 
    {
        /// <summary>
        /// Collection of Migration units
        /// </summary>
        [JsonProperty(PropertyName = "list", Required = Required.AllowNull)]
        public IList<NSXTMigrationUnitType> List { get; set; }
    }
}
