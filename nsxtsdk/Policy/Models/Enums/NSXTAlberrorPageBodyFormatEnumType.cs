// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using System.Runtime.Serialization;
using nsxtsdk.Models;

namespace nsxtsdk.PolicyModels
{
    /// <summary>
    /// Format of an error page body HTML or JSON.Enum options - ERROR_PAGE_FORMAT_HTML,ERROR_PAGE_FORMAT_JSON.Default value when not specified in API or module isinterpreted by ALB Controller as ERROR_PAGE_FORMAT_HTML.
    /// </summary>
    [NSXTProperty(Description: @"Format of an error page body HTML or JSON.Enum options - ERROR_PAGE_FORMAT_HTML,ERROR_PAGE_FORMAT_JSON.Default value when not specified in API or module isinterpreted by ALB Controller as ERROR_PAGE_FORMAT_HTML.")]
    public enum NSXTAlberrorPageBodyFormatEnumType
    {
        [EnumMember(Value = "ERROR_PAGE_FORMAT_HTML")]
        ERRORPAGEFORMATHTML = 1,
        [EnumMember(Value = "ERROR_PAGE_FORMAT_JSON")]
        ERRORPAGEFORMATJSON = 2,
    }
}
