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

namespace nsxtsdk.ManagerModels
{
    /// <summary>
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTTransportNodeStateListResultType : NSXTListResultType
    {
        /// <summary>
        /// Transport Node State Results
        /// </summary>
        public IList<NSXTTransportNodeStateType> Results { get; set; }
    }
}
