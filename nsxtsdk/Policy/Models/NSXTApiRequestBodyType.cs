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
    public class NSXTApiRequestBodyType : NSXTSourceType
    {
        /// <summary>
        /// Regex path representing a regex expression on resources. This regex is used
        /// to identify the request body(ies) that is/are the source of the Event. For
        /// instance: specifying "Lb* | /infra/tier-0s/vmc/ipsec-vpn-services/default"
        /// as a source means that ANY resource starting with Lb or ANY resource with
        /// "/infra/tier-0s/vmc/ipsec-vpn-services/default" as path would be the source
        /// of the event in question.
        /// </summary>
        [JsonProperty(PropertyName = "resource_pointer", Required = Required.AllowNull)]
        public string ResourcePointer { get; set; }
    }
}
