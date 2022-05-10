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
    public class NSXTServiceInsertionStatusType : NSXTManagedResourceType
    {
        /// <summary>
        /// service insertion status for a context type (e.g. east_west traffic).
        /// </summary>
        [JsonProperty(PropertyName = "global_status", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTServiceInsertionStatusGlobalStatusEnumType GlobalStatus { get; set; }
        /// <summary>
        /// Type of service insertion contexts.
        /// </summary>
        [JsonProperty(PropertyName = "context", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTServiceInsertionStatusContextEnumType Context { get; set; }
    }
}
