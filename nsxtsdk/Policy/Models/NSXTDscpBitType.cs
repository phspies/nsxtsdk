using nsxtsdk.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.ComponentModel;
using NJsonSchema.Converters;
using Newtonsoft.Json.Converters;

namespace nsxtsdk.PolicyModels
{
    /// <summary>
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTDscpBitType : NSXTDscpIndicatorType
    {
        /// <summary>
        /// A DSCP bit is allocated to indicate the existence of INT header. It takes
        /// effect only when the INT indicator mode is DSCP_BIT. The user should
        /// guarantee that the given DSCP bit is specifically allocated for INT.
        /// </summary>
        [JsonProperty(PropertyName = "dscp_bit", Required = Required.AllowNull)]
        public int DscpBit { get; set; }
    }
}
