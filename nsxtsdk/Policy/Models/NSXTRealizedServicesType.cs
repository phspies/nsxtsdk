// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using nsxtsdk.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using NJsonSchema.Converters;
using System.ComponentModel;

namespace nsxtsdk.PolicyModels
{
    /// <summary>
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTRealizedServicesType : NSXTPolicyRealizedResourceType
    {
        /// <summary>
        /// List of realized services
        /// </summary>
        [JsonProperty(PropertyName = "realized_services")]
        [NSXTProperty(IsRequired: false, Description: @"List of realized services")]
        public IList<NSXTRealizedServiceType> RealizedServices { get; set; }
    }
}
