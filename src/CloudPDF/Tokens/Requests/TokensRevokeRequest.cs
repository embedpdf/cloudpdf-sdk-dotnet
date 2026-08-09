using CloudPDF.Core;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[Serializable]
public record TokensRevokeRequest
{
    [JsonIgnore]
    public required string TenantId { get; set; }

    [JsonIgnore]
    public required string Jti { get; set; }

    [JsonPropertyName("reason")]
    public string? Reason { get; set; }

    [JsonPropertyName("expiresAtSeconds")]
    public int? ExpiresAtSeconds { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
