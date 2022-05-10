using nsxtsdk.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.ComponentModel;
using NJsonSchema.Converters;
using Newtonsoft.Json.Converters;

namespace nsxtsdk.PolicyModels
{
    /// <summary>
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTALBAlertScriptConfigType : NSXTPolicyConfigResourceType
    {
        /// <summary>
        /// User Defined Alert Action Script.
        /// Please refer to kb.avinetworks.com for more information.
        /// </summary>
        [JsonProperty(PropertyName = "action_script")]
        public string? ActionScript { get; set; }
    }
}
