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
    public class NSXTTransportNodeSpanEnforcedStatusType : NSXTEnforcedStatusPerScopeNsxTType
    {
        /// <summary>
        /// List of Detailed Realized Status per Transport Node.
        /// </summary>
        public IList<NSXTEnforcedStatusPerTransportNodeType> EnforcedStatusPerTransportNode { get; set; }
    }
}
