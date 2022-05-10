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
    public class NSXTLicensesListResultType : NSXTListResultType
    {
        /// <summary>
        /// Licenses Results
        /// </summary>
        [JsonProperty(PropertyName = "results")]
        public IList<NSXTLicenseType> Results { get; set; }
    }
}
