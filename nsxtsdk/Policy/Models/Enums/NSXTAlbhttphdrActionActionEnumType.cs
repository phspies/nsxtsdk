// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using System.Runtime.Serialization;
using nsxtsdk.Models;

namespace nsxtsdk.PolicyModels
{
    /// <summary>
    /// ADD  A new header with the new value is added irrespectiveof the existence of an HTTP header of the given name.REPLACE  A new header with the new value is added if noheader of the given name exists, else existing headers withthe given name are removed and a new header with the newvalue is added.REMOVE  All the headers of the given name are removed.Enum options - HTTP_ADD_HDR, HTTP_REMOVE_HDR,HTTP_REPLACE_HDR.Allowed in Basic(Allowed values-HTTP_REMOVE_HDR,HTTP_REPLACE_HDR) edition,Essentials(Allowed values- HTTP_REMOVE_HDR,HTTP_REPLACE_HDR)edition, Enterprise edition.
    /// </summary>
    [NSXTProperty(Description: @"ADD  A new header with the new value is added irrespectiveof the existence of an HTTP header of the given name.REPLACE  A new header with the new value is added if noheader of the given name exists, else existing headers withthe given name are removed and a new header with the newvalue is added.REMOVE  All the headers of the given name are removed.Enum options - HTTP_ADD_HDR, HTTP_REMOVE_HDR,HTTP_REPLACE_HDR.Allowed in Basic(Allowed values-HTTP_REMOVE_HDR,HTTP_REPLACE_HDR) edition,Essentials(Allowed values- HTTP_REMOVE_HDR,HTTP_REPLACE_HDR)edition, Enterprise edition.")]
    public enum NSXTAlbhttphdrActionActionEnumType
    {
        [EnumMember(Value = "HTTP_ADD_HDR")]
        HTTPADDHDR = 1,
        [EnumMember(Value = "HTTP_REMOVE_HDR")]
        HTTPREMOVEHDR = 2,
        [EnumMember(Value = "HTTP_REPLACE_HDR")]
        HTTPREPLACEHDR = 3,
    }
}
