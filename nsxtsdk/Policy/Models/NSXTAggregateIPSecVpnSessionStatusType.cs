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
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTAggregateIPSecVpnSessionStatusType : NSXTAggregatePolicyRuntimeInfoType
    {
        /// <summary>
        /// List of IPSec VPN Session Status per Enforcement Point.
        /// </summary>
        public IList<NSXTIPSecVpnSessionStatusPerEPType> Results { get; set; }
    }
}
