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
    public class NSXTReorderMigrationRequestType 
    {
        /// <summary>
        /// flag indicating whether the migration unit group/migration unit is to be placed before or after the specified migration
        /// unit group/migration unit
        /// </summary>
        [JsonProperty(PropertyName = "is_before")]
        public bool? IsBefore { get; set; }
        /// <summary>
        /// id of the migration unit group/migration unit before/after which the migration unit group/migration unit is to be placed
        /// </summary>
        [JsonProperty(PropertyName = "id", Required = Required.AllowNull)]
        public string Id { get; set; }
    }
}
