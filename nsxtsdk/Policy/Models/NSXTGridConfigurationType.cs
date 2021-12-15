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
    public class NSXTGridConfigurationType : NSXTWidgetConfigurationType
    {
        /// <summary>
        /// Number of records per page. page_size will be effective only when the urls provided in the datasource support paging.
        /// </summary>
        [JsonProperty(PropertyName = "page_size")]
        [NSXTProperty(IsRequired: false, Description: @"Number of records per page. page_size will be effective only when the urls provided in the datasource support paging.")]
        [NSXTDefaultProperty(Default: "")]
        public long? PageSize { get; set; }
        /// <summary>
        /// Rows of grid or table are formed from the list of objects returned by a row list field.
        /// </summary>
        [JsonProperty(PropertyName = "row_list_fields", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"Rows of grid or table are formed from the list of objects returned by a row list field.")]
        [System.ComponentModel.DataAnnotations.Required]
        public IList<NSXTRowListFieldType> RowListFields { get; set; }
        /// <summary>
        /// Array of columns of a Grid widget
        /// </summary>
        [JsonProperty(PropertyName = "columns", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"Array of columns of a Grid widget")]
        [System.ComponentModel.DataAnnotations.Required]
        public IList<NSXTColumnItemType> Columns { get; set; }
    }
}
