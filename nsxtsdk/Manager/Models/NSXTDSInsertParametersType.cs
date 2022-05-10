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
    /// Parameters to tell where rule/section need to be added. All the params take rule/section Id.
    /// </summary>
    [NSXTProperty(Description: @"Parameters to tell where rule/section need to be added. All the params take rule/section Id.")]
    public class NSXTDSInsertParametersType 
    {
        /// <summary>
        /// Operation
        /// </summary>
        [JsonProperty(PropertyName = "operation")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTDsinsertParametersOperationEnumType? Operation { get; set; }
        /// <summary>
        /// Identifier of the anchor rule or section. This is a required field in case operation like 'insert_before' and
        /// 'insert_after'.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string? Id { get; set; }
    }
}
