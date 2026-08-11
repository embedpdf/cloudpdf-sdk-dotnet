using CloudPDF.Core;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[Serializable]
public record TenantsSuspendRequest
{
    [JsonIgnore]
    public required string TenantId { get; set; }

    [JsonPropertyName("reason")]
    public string? Reason { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
