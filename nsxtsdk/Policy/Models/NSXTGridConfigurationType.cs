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
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTGridConfigurationType : NSXTWidgetConfigurationType
    {
        /// <summary>
        /// Number of records per page. page_size will be effective only when the urls provided in the datasource support paging.
        /// </summary>
        [JsonProperty(PropertyName = "page_size")]
        public int? PageSize { get; set; }
        /// <summary>
        /// Rows of grid or table are formed from the list of objects returned by a row list field.
        /// </summary>
        [JsonProperty(PropertyName = "row_list_fields", Required = Required.AllowNull)]
        public IList<NSXTRowListFieldType> RowListFields { get; set; }
        /// <summary>
        /// Array of columns of a Grid widget
        /// </summary>
        [JsonProperty(PropertyName = "columns", Required = Required.AllowNull)]
        public IList<NSXTColumnItemType> Columns { get; set; }
    }
}
