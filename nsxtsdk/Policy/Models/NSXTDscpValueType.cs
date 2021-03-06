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
    public class NSXTDscpValueType : NSXTDscpIndicatorType
    {
        /// <summary>
        /// A DSCP value is allocated to indicate the existence of INT header. It takes
        /// effects only when the INT indicator mode is DSCP_VALUE. The user should
        /// guarantee that the given DSCP value is specifically allocated for INT.
        /// </summary>
        [JsonProperty(PropertyName = "dscp_value", Required = Required.AllowNull)]
        public int DscpValue { get; set; }
    }
}
