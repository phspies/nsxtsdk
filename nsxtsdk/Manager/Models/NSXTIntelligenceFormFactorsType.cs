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
    /// Napp cluster form factors list result
    /// </summary>
    [NSXTProperty(Description: @"Napp cluster form factors list result")]
    public class NSXTIntelligenceFormFactorsType 
    {
        /// <summary>
        /// Napp cluster form factor list
        /// </summary>
        [JsonProperty(PropertyName = "form_factors")]
        public IList<NSXTIntelligenceFormFactorType> FormFactors { get; set; }
    }
}
