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
    /// Collection of various x509 v3 extensions to be added to a CSR
    /// </summary>
    [NSXTProperty(Description: @"Collection of various x509 v3 extensions to be added to a CSR")]
    public class NSXTCsrExtensionsType 
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "subject_alt_names")]
        public NSXTSubjectAltNamesType SubjectAltNames { get; set; }
    }
}
