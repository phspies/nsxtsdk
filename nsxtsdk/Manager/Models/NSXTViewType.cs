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
    public class NSXTViewType : NSXTManagedResourceType
    {
        /// <summary>
        /// Comma separated list of roles to which the shared view is visible. Allows user to specify the visibility of a shared
        /// view to the specified roles. User defined roles can also be specified in the list. The roles can be obtained via GET
        /// /api/v1/aaa/roles. Please visit API documentation for details about roles.
        /// </summary>
        [JsonProperty(PropertyName = "include_roles")]
        public string? IncludeRoles { get; set; }
        /// <summary>
        /// Title of the widget.
        /// </summary>
        [JsonProperty(PropertyName = "display_name", Required = Required.AllowNull)]
        public string DisplayName { get; set; }
        /// <summary>
        /// Comma separated list of roles to which the shared view is not visible. Allows user to prevent the visibility of a shared
        /// view to the specified roles. User defined roles can also be specified in the list. The roles can be obtained via GET
        /// /api/v1/aaa/roles. Please visit API documentation for details about roles. If include_roles is specified then
        /// exclude_roles cannot be specified.
        /// </summary>
        [JsonProperty(PropertyName = "exclude_roles")]
        public string? ExcludeRoles { get; set; }
        /// <summary>
        /// Determines placement of view relative to other views. The lower the weight, the higher it is in the placement order.
        /// </summary>
        [JsonProperty(PropertyName = "weight")]
        public int? Weight { get; set; }
        /// <summary>
        /// Array of widgets that are part of the view.
        /// </summary>
        [JsonProperty(PropertyName = "widgets", Required = Required.AllowNull)]
        public IList<NSXTWidgetItemType> Widgets { get; set; }
        /// <summary>
        /// Defaults to false. Set to true to publish the view to other users. The widgets of a shared view are visible to other
        /// users.
        /// </summary>
        [JsonProperty(PropertyName = "shared")]
        public bool? Shared { get; set; }
    }
}
