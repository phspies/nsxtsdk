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
    /// Parameters to let the admin specify a relative position of a security
        /// policy or rule w.r.t to another one.
    /// </summary>
    [NSXTProperty(Description: @"Parameters to let the admin specify a relative position of a securitypolicy or rule w.r.t to another one.")]
    public class NSXTPolicyInsertParametersType 
    {
        /// <summary>
        /// The security policy/rule path if operation is 'insert_after' or
        /// 'insert_before'
        /// </summary>
        [JsonProperty(PropertyName = "anchor_path")]
        public string? AnchorPath { get; set; }
        /// <summary>
        /// Operation
        /// </summary>
        [JsonProperty(PropertyName = "operation")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTPolicyInsertParametersOperationEnumType? Operation { get; set; }
    }
}
