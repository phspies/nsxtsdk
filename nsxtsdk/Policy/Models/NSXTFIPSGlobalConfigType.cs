// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using nsxtsdk.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.ComponentModel;
using NJsonSchema.Converters;

namespace nsxtsdk.PolicyModels
{
    /// <summary>
    /// Global configuration
    /// </summary>
    [NSXTProperty(Description: @"Global configuration")]
    public class NSXTFIPSGlobalConfigType 
    {
        /// <summary>
        /// When this flag is set to true FIPS mode will be set on ssl encryptions of load balancer feature.
        /// </summary>
        public bool? LbFipsEnabled { get; set; }
        /// <summary>
        /// When this flag is set to true FIPS mode will be set on ssl encryptions of TLS inspection feature.
        /// </summary>
        public bool? TlsFipsEnabled { get; set; }
    }
}
