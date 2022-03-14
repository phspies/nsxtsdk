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

namespace nsxtsdk.PolicyModels
{
    /// <summary>
    /// Form factor contains, resources required to deploy
        /// NSX Application Platform deployment and available features for a given
        /// form factor.
    /// </summary>
    [NSXTProperty(Description: @"Form factor contains, resources required to deployNSX Application Platform deployment and available features for a givenform factor.")]
    public class NSXTFormFactorDetailType 
    {
        /// <summary>
        /// 
        /// </summary>
        public NSXTNodeResourcesType NodeResources { get; set; }
        /// <summary>
        /// Features supported in this form factor.
        /// </summary>
        public IList<string> SupportedFeatures { get; set; }
    }
}
