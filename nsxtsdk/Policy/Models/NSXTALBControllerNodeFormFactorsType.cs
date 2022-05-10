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
    /// Advanced Load Balancer controller form factors list result
    /// </summary>
    [NSXTProperty(Description: @"Advanced Load Balancer controller form factors list result")]
    public class NSXTALBControllerNodeFormFactorsType 
    {
        /// <summary>
        /// Advanced Load Balancer controller form factor list
        /// </summary>
        [JsonProperty(PropertyName = "form_factors")]
        public IList<NSXTALBControllerNodeFormFactorType> FormFactors { get; set; }
    }
}
