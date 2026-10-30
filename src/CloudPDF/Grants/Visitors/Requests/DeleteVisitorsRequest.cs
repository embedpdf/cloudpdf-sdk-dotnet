using CloudPDF.Core;
using global::System.Text.Json.Serialization;

namespace CloudPDF.Grants;

[Serializable]
public record DeleteVisitorsRequest
{
    [JsonIgnore]
    public required string TenantId { get; set; }

    [JsonIgnore]
    public required string GrantId { get; set; }

    [JsonIgnore]
    public required string VisitorId { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
