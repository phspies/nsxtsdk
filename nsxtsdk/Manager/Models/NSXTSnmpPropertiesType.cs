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
    /// This object contains SNMP v2c and SNMP v3 properties.
    /// </summary>
    [NSXTProperty(Description: @"This object contains SNMP v2c and SNMP v3 properties.")]
    public class NSXTSnmpPropertiesType 
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "v2c")]
        public NSXTSnmpv2cPropertiesType V2c { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "v3")]
        public NSXTSnmpv3PropertiesType V3 { get; set; }
    }
}
