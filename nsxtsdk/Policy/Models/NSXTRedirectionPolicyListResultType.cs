// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using nsxtsdk.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using NJsonSchema.Converters;
using System.ComponentModel;

namespace nsxtsdk.PolicyModels
{
    /// <summary>
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTRedirectionPolicyListResultType : NSXTPolicyListResultType
    {
        public NSXTRedirectionPolicyListResultType()
        {
        }
        /// <summary>
        /// Redirection policy list results
        /// </summary>
        [JsonProperty(PropertyName = "results", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"Redirection policy list results")]
        [System.ComponentModel.DataAnnotations.Required]
        public IList<NSXTRedirectionPolicyType> Results { get; set; }
    }
}
