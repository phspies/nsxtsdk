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
    public class NSXTNodeSnmpV3EngineIDType : NSXTNodeServicePropertiesType
    {
        /// <summary>
        /// SNMP v3 engine id
        /// </summary>
        [JsonProperty(PropertyName = "v3_engine_id", Required = Required.AllowNull)]
        public string V3EngineId { get; set; }
    }
}
