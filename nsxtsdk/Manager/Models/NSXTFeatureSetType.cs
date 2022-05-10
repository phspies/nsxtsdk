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
    /// Represents list of features required to view the widget.
    /// </summary>
    [NSXTProperty(Description: @"Represents list of features required to view the widget.")]
    public class NSXTFeatureSetType 
    {
        /// <summary>
        /// List of features required for to view widget.
        /// </summary>
        [JsonProperty(PropertyName = "feature_list")]
        public IList<string> FeatureList { get; set; }
        /// <summary>
        /// Flag for specifying if permission to all features is required If set to false, then if there is permission for any of
        /// the feature from feature list, widget will be available.
        /// </summary>
        [JsonProperty(PropertyName = "require_all_permissions")]
        public bool? RequireAllPermissions { get; set; }
    }
}
