using nsxtsdk.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.ComponentModel;
using NJsonSchema.Converters;
using Newtonsoft.Json.Converters;

namespace nsxtsdk.ManagerModels
{
    /// <summary>
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTEULAAcceptanceType : NSXTManagedResourceType
    {
        /// <summary>
        /// Acceptance status of End User License Agreement
        /// </summary>
        [JsonProperty(PropertyName = "acceptance", Required = Required.AllowNull)]
        public bool Acceptance { get; set; }
    }
}
