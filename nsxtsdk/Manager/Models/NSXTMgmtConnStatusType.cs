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

namespace nsxtsdk.ManagerModels
{
    /// <summary>
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTMgmtConnStatusType 
    {
        public NSXTMgmtConnStatusType()
        {
        }
        /// <summary>
        /// Indicates the controller node's MP channel connectivity status
        /// </summary>
        [JsonProperty(PropertyName = "connectivity_status")]
        [NSXTProperty(IsRequired: false, Description: @"Indicates the controller node&apos;s MP channel connectivity status")]
        public NSXTMgmtConnStatusConnectivityStatusEnumType? ConnectivityStatus { get; set; }
    }
}
