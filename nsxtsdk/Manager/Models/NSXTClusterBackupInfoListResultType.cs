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
    public class NSXTClusterBackupInfoListResultType : NSXTListResultType
    {
        /// <summary>
        /// List of timestamps of backed-up cluster files
        /// </summary>
        [JsonProperty(PropertyName = "results")]
        public IList<NSXTClusterBackupInfoType> Results { get; set; }
    }
}
