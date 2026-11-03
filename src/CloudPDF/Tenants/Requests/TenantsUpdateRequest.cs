using CloudPDF.Core;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[Serializable]
public record TenantsUpdateRequest
{
    [JsonIgnore]
    public required string TenantId { get; set; }

    [JsonPropertyName("features")]
    public IEnumerable<TenantFeature> Features { get; set; } = new List<TenantFeature>();

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
