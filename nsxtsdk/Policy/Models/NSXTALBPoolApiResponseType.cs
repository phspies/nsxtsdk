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
    public class NSXTALBPoolApiResponseType : NSXTListResultType
    {
        /// <summary>
        /// count
        /// </summary>
        public int? Count { get; set; }
        /// <summary>
        /// Array of Pool
        /// </summary>
        public IList<NSXTALBPoolType> Results { get; set; }
    }
}
